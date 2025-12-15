import React from "react";
import { X, AlertCircle } from "lucide-react";



interface Props {
  onClose: () => void;
}

export default function DuplicateBookingModal({ onClose }: Props) {
  return (
    <div className="fixed inset-0 bg-black bg-opacity-60 flex items-center justify-center z-50 p-4">
      <div className="bg-white rounded-3xl shadow-2xl max-w-lg w-full p-10 text-center relative">

        {/* Close X */}
        <button
          onClick={onClose}
          className="absolute top-4 right-4 text-gray-400 hover:text-gray-700 transition"
        >
          <X size={32} />
        </button>

        {/* Warning Icon */}
        <div className="mx-auto mb-6 w-24 h-24 bg-orange-100 rounded-full flex items-center justify-center">
          <AlertCircle size={56} className="text-orange-600" />
        </div>

        <h1 className="text-4xl font-black text-gray-900 mb-4">
          You Already Have an Appointment
        </h1>

        <p className="text-lg text-gray-600 mb-8">
          Only one appointment is allowed at a time.
        </p>

        <div className="bg-amber-50 border border-amber-200 rounded-2xl p-5 mb-8">
          <p className="text-gray-800 font-medium leading-relaxed">
            If you would like to schedule a new appointment, please{" "}
            <strong>cancel your current one first</strong> by clicking the{" "}
            <span className="text-blue-600 font-bold">Cancel Appointment</span> link in the confirmation email we sent you.
          </p>
        </div>

        <button
          onClick={onClose}
          className="w-full bg-blue-600 text-white py-5 rounded-2xl font-bold text-xl hover:bg-blue-700 transition shadow-xl"
        >
          Got It, Thanks
        </button>
      </div>
    </div>
  );
}