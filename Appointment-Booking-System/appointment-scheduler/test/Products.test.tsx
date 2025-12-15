import React from 'react';
import { render, screen } from '@testing-library/react';
import '@testing-library/jest-dom';
import { MemoryRouter } from 'react-router-dom';
import Products from '../src/pages/Products';

describe('Products', () => {
  it('renders Products page', () => {
    render(
      <MemoryRouter>
        <Products />
      </MemoryRouter>
    );
    expect(screen.getByText(/products/i)).toBeInTheDocument();
  });
});
