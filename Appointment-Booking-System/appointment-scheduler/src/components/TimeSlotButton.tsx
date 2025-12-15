import React from 'react';
import type { TimeSlot } from "../types";  
interface Props {
  slot: TimeSlot;
  selected: boolean;
  onClick: () => void;
}

export default function TimeSlotButton({ slot, selected, onClick }: Props) {
  return (
    <button
      onClick={onClick}
      disabled={!slot.isAvailable}
      className={`px-5 py-4 rounded-lg font-medium transition-all ${
        !slot.isAvailable
          ? "bg-gray-200 text-gray-500 cursor-not-allowed"
          : selected
          ? "bg-blue-600 text-white shadow-lg scale-105"
          : "bg-white border-2 border-blue-600 text-blue-600 hover:bg-blue-50"
      }`}
    >
      {slot.time}
    </button>
  );
}