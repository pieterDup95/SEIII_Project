import React from 'react';
import { render, screen } from '@testing-library/react';
import '@testing-library/jest-dom';
import TimeSlotButton from '../src/components/TimeSlotButton';
import type { TimeSlot } from '../src/types';

describe('TimeSlotButton', () => {
  it('renders slot time', () => {
    const slot: TimeSlot = { time: '09:00', isAvailable: true };
    render(<TimeSlotButton slot={slot} selected={false} onClick={() => {}} />);
    expect(screen.getByText('09:00')).toBeInTheDocument();
  });
});
