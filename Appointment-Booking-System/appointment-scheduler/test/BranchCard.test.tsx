import React from 'react';
import { render, screen } from '@testing-library/react';
import '@testing-library/jest-dom';
import BranchCard from '../src/components/BranchCard';
import type { Branch } from '../src/types';

describe('BranchCard', () => {
  it('renders branch name', () => {
    const branch: Branch = {
      id: '1',
      branchName: 'Test Branch',
      branchCode: 123,
      provice: 'Province',
      city: 'Test City',
      suburb: 'Test Suburb',
      address: '123 Test St',
      contactNumber: '1234567890',
      slotPerHour: 4,
      slotDuration: 15,
      operationalHours: [],
      publicHolidays: []
    };
    render(<BranchCard branch={branch} selected={false} onClick={() => {}} />);
    expect(screen.getByText('Test Branch')).toBeInTheDocument();
  });
});
