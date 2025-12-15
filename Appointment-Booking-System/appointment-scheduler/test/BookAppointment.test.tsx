import React from 'react';
import React from 'react';
import { render, screen, fireEvent, waitFor } from '@testing-library/react';
import { MemoryRouter } from 'react-router-dom';
import BookAppointment from '../src/pages/BookAppointment';
import { vi, describe, it, expect } from 'vitest';
import '@testing-library/jest-dom';

vi.mock('../src/api/api', () => ({
  getBranches: vi.fn(async (_search) => [
    { id: '1', branchName: 'Test Branch', address: '123 Main St', city: 'Testville', slotDuration: 30, operationalHours: [{ dayOfWeek: 1 }], publicHolidays: [] }
  ]),
  getAvailability: vi.fn(async (_branchId, _dateStr) => ({
    timeSlots: [
      { time: '09:00', isAvailable: true },
      { time: '09:30', isAvailable: false }
    ]
  })),
  createAppointment: vi.fn(async (data) => ({
    appointmentId: 'abc123',
    referenceNumber: 'REF-123',
    status: 'Confirmed',
    ...data
  }))
}));

describe('BookAppointment', () => {
  it('renders branch search and allows branch selection', async () => {
    render(
      <MemoryRouter>
        <BookAppointment />
      </MemoryRouter>
    );
    expect(screen.getByPlaceholderText(/search by name/i)).toBeInTheDocument();
    await waitFor(() => expect(screen.getByText('Test Branch')).toBeInTheDocument());
    fireEvent.click(screen.getByText('Test Branch'));
    expect(screen.getByText(/select date & time/i)).toBeInTheDocument();
  });

  it('shows available time slots after selecting branch and date', async () => {
    render(
      <MemoryRouter>
        <BookAppointment />
      </MemoryRouter>
    );
    await waitFor(() => screen.getByText('Test Branch'));
    fireEvent.click(screen.getByText('Test Branch'));
    await waitFor(() => screen.getByText(/select date & time/i));
    // Simulate picking a date (today)
    const today = new Date();
    fireEvent.click(screen.getByText(today.getDate().toString()));
    await waitFor(() => screen.getByText('09:00'));
    expect(screen.getByText('09:00')).toBeInTheDocument();
    expect(screen.getByText('09:30')).toBeInTheDocument();
  });

  it('can complete the booking flow', async () => {
    render(
      <MemoryRouter>
        <BookAppointment />
      </MemoryRouter>
    );
    await waitFor(() => screen.getByText('Test Branch'));
    fireEvent.click(screen.getByText('Test Branch'));
    await waitFor(() => screen.getByText(/select date & time/i));
    const today = new Date();
    fireEvent.click(screen.getByText(today.getDate().toString()));
    await waitFor(() => screen.getByText('09:00'));
    fireEvent.click(screen.getByText('09:00'));
    fireEvent.click(screen.getByText(/continue/i));
    await waitFor(() => screen.getByText(/your information/i));
    fireEvent.change(screen.getByPlaceholderText(/full name/i), { target: { value: 'John Doe' } });
    fireEvent.change(screen.getByPlaceholderText(/id number/i), { target: { value: '1234567890123' } });
    fireEvent.change(screen.getByPlaceholderText(/mobile number/i), { target: { value: '0821234567' } });
    fireEvent.change(screen.getByPlaceholderText(/email address/i), { target: { value: 'john@example.com' } });
    fireEvent.click(screen.getByText(/confirm appointment/i));
    await waitFor(() => screen.getByText(/appointment confirmed/i));
  });
});
