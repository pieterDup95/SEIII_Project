import React from 'react';
import { render, screen } from '@testing-library/react';
import '@testing-library/jest-dom';
import { MemoryRouter } from 'react-router-dom';
import Footer from '../src/components/Footer';

describe('Footer', () => {
  it('renders the footer', () => {
    render(
      <MemoryRouter>
        <Footer />
      </MemoryRouter>
    );
    expect(screen.getByRole('contentinfo')).toBeInTheDocument();
  });
});
