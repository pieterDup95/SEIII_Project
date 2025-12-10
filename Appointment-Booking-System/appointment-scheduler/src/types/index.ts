// src/types/index.ts

export interface OperationalHour {
  dayOfWeek: number;        // 0 = Sunday, 1 = Monday, ..., 6 = Saturday
  openTime: string;         // "08:00:00"
  closeTime: string;        // "17:00:00"
}

export interface Branch {
  id: string;
  branchName: string;
  branchCode: number;
  provice: string;          
  city: string;
  suburb: string;
  address: string;
  contactNumber: string;
  slotPerHour: number;
  operationalHours: OperationalHour[];
}

// Optional: if you want a nicer name without the typo in your components
// you can create an alias (recommended)
export type BranchModel = Branch;

export interface TimeSlot {
  time: string;             // "09:00"
  isAvailable: boolean;
}

// Updated to match real response from /availability endpoint
export interface BranchAvailability {
  branchId: string;
  date: string;
  timeSlots: TimeSlot[];
  // Some endpoints might return isOpen: false instead of empty array
  isOpen?: boolean;
}

export interface CreateAppointmentRequest {
  branchId: string;
  branchName: string;
  date: string;             // YYYY-MM-DD
  time: string;             // "09:30"
  customer: {
    fullName: string;
    idNumber: string;
    contactNumber: string;
    email: string;
    notes?: string;
  };
}

export interface AppointmentResponse {
  appointmentId: string;
  referenceNumber: string;
  branchId: string;
  date: string;
  time: string;
  status: string;
  message?: string;
}