import React from "react";
import { CheckCircle, MapPin, Calendar, Clock, X } from "lucide-react";
import { format } from "date-fns";
import type { AppointmentResponse, Branch } from "../types";

interface Props {
  appointment: AppointmentResponse;
  branch: Branch;
  onClose: () => void;
}

export default function ConfirmationModal({ appointment, branch, onClose }: Props) {
  return (
    <div className="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50 p-4">
      <div className="bg-white rounded-2xl shadow-2xl max-w-lg w-full p-10 text-center relative">

        {/* Optional: X button top-right */}
        <button
          onClick={onClose}
          className="absolute top-4 right-4 text-gray-400 hover:text-gray-600 transition"
        >
          <X size={28} />
        </button>

        <CheckCircle size={80} className="text-green-500 mx-auto mb-6" />
        <h1 className="text-4xl font-bold mb-4">Appointment Confirmed!</h1>
        <p className="text-3xl font-bold text-blue-600 mb-8">{appointment.referenceNumber}</p>

        <div className="text-left space-y-4 text-gray-700 mb-10">
          <p className="flex items-center gap-3">
            <MapPin size={20} className="text-blue-600" />
            <span>
              <strong>Branch:</strong> {branch.branchName}, {branch.city}
            </span>
          </p>
          <p className="flex items-center gap-3">
            <Calendar size={20} className="text-blue-600" />
            <span>
              <strong>Date:</strong> {format(new Date(appointment.date), "EEEE, dd MMMM yyyy")}
            </span>
          </p>
          <p className="flex items-center gap-3">
            <Clock size={20} className="text-blue-600" />
            <span>
              <strong>Time:</strong> {appointment.time}
            </span>
          </p>
          <p className="text-green-600 font-bold text-lg">
            Status: {appointment.status}
          </p>
        </div>

        <button
          onClick={onClose}
          className="w-full max-w-xs mx-auto bg-blue-600 text-white py-4 rounded-xl font-bold text-xl hover:bg-blue-700 transition shadow-lg"
        >
          Close
        </button>

        <p className="text-sm text-gray-500 mt-6">
          A confirmation has been sent to your phone and email.
        </p>
      </div>
    </div>
  );
}