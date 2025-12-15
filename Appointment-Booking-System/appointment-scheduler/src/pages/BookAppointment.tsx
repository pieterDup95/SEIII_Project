import React from "react";
import { useState, useEffect } from "react";
import { useForm } from "react-hook-form";
import { zodResolver } from "@hookform/resolvers/zod";
import * as z from "zod";
import { format } from "date-fns";
import DatePicker from "react-datepicker";
import "react-datepicker/dist/react-datepicker.css";
import { useNavigate } from "react-router-dom";

import {
  Search,
  Clock,
  Calendar,
  MapPin,
  User,
  ChevronLeft,
  ChevronRight,
  Check,
  AlertCircle,
  RefreshCw,
} from "lucide-react";

import { getBranches, getAvailability, createAppointment } from "../api/api";
import type { Branch, TimeSlot, AppointmentResponse } from "../types";
import BranchCard from "../components/BranchCard";
import ConfirmationModal from "../components/ConfirmationModal";
import DuplicateBookingModal from "../components/DuplicateBookingModal";

const schema = z.object({
  fullName: z.string().min(2, "Full name required"),
  idNumber: z.string().length(13, "Must be 13 digits").regex(/^\d+$/, "Numbers only"),
  contactNumber: z.string().regex(/^0\d{9}$/, "Valid SA mobile number (e.g. 0821234567)"),
  email: z.string().email("Invalid email address"),
  notes: z.string().optional(),
});

type FormData = z.infer<typeof schema>;
type Tab = "branch" | "datetime" | "info";

export default function BookAppointment() {
  const [activeTab, setActiveTab] = useState<Tab>("branch");
  const [search, setSearch] = useState("");
  const [selectedBranch, setSelectedBranch] = useState<Branch | null>(null);
  const [date, setDate] = useState<Date | null>(null);
  const [selectedTime, setSelectedTime] = useState("");
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [appointment, setAppointment] = useState<AppointmentResponse | null>(null);

  const navigate = useNavigate();
  // API States
  const [branches, setBranches] = useState<Branch[]>([]);
  const [branchesLoading, setBranchesLoading] = useState(true);
  const [branchesError, setBranchesError] = useState<string | null>(null);

  const [slots, setSlots] = useState<TimeSlot[]>([]);
  const [slotsLoading, setSlotsLoading] = useState(false);
  const [slotsError, setSlotsError] = useState<string | null>(null);

  const [bookingError, setBookingError] = useState<string | null>(null);
  const [showDuplicateModal, setShowDuplicateModal] = useState(false);
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<FormData>({
    resolver: zodResolver(schema),
  });

  // Load branches
  useEffect(() => {
    const timer = setTimeout(async () => {
      setBranchesLoading(true);
      setBranchesError(null);
      try {
        const data = await getBranches(search);
        setBranches(data);
      } catch {
        setBranchesError("We're sorry, something went wrong on our end. Please try again later.");
        setBranches([]);
      } finally {
        setBranchesLoading(false);
      }
    }, 300);
    return () => clearTimeout(timer);
  }, [search]);

  // Load time slots
  useEffect(() => {
    if (!selectedBranch || !date || activeTab !== "datetime") return;

    const dateStr = format(date, "yyyy-MM-dd");
    setSlotsLoading(true);
    setSlotsError(null);

    getAvailability(selectedBranch.id, dateStr)
      .then((res) => {
        const timeSlots = "timeSlots" in res ? res.timeSlots : [];
        setSlots(timeSlots);
        if (timeSlots.length === 0 && !slotsLoading) {
          setSlotsError("No available slots on this date");
        }
      })
      .catch(() => {
        setSlotsError("We're sorry, something went wrong on our end. Please try again later.");
        setSlots([]);
      })
      .finally(() => setSlotsLoading(false));
  }, [selectedBranch, date, activeTab]);

  const onSubmit = async (data: FormData) => {
    if (!selectedBranch || !date || !selectedTime) return;

    setIsSubmitting(true);
    setBookingError(null);
    setShowDuplicateModal(false);

    try {
      const result = await createAppointment({
        branchId: selectedBranch.id,
        branchName: selectedBranch.branchName,
        date: format(date, "yyyy-MM-dd"),
        time: selectedTime,
        customer: { ...data },
      });
      setAppointment(result);
    } catch (err: any) {
 
      if (err.status === 409 && err.body?.error === "DuplicateBooking") {
        setShowDuplicateModal(true);
        return;
      } 
        setBookingError("We're sorry, something went wrong on our end. Please try again later.");
        console.error("Booking error:", err);
      
    } finally {
      setIsSubmitting(false);
    }
  };

  
  const isPublicHoliday = (d: Date): boolean => {
    if (!selectedBranch?.publicHolidays) return false;
    const dateStr = format(d, "yyyy-MM-dd");
    return selectedBranch.publicHolidays.includes(dateStr);
  };

  const getOpenDays = (): number[] => {
    return selectedBranch?.operationalHours.map(h => h.dayOfWeek) || [];
  };

  const isDayDisabled = (d: Date) => {
    const isClosedDay = !getOpenDays().includes(d.getDay());
    const isHoliday = isPublicHoliday(d);

    return isClosedDay || isHoliday;
  };

  const goBack = () => {
    if (activeTab === "datetime") setActiveTab("branch");
    if (activeTab === "info") setActiveTab("datetime");
  };

  const scrollToTop = () => window.scrollTo({ top: 0, behavior: "smooth" });

  // Confirmatuion
  if (appointment && selectedBranch) {
    return (
      <ConfirmationModal
        appointment={appointment}
        branch={selectedBranch}
        onClose={() => navigate("/")}  
      />
    );
  }
  //Duplicate booking
  if (showDuplicateModal) {
    return (
      <DuplicateBookingModal
        onClose={() => {
          setShowDuplicateModal(false);
          navigate("/");
          scrollToTop();
        }}
      />
    );
  }

  return (
    <div className="min-h-screen bg-gray-50 py-12">
      <div className="max-w-4xl mx-auto px-6">
        {/* Header */}
        <div className="flex items-center justify-between mb-8">
          {activeTab !== "branch" && (
            <button
              onClick={() => {
                goBack();
                setTimeout(scrollToTop, 100);
              }}
              className="flex items-center gap-2 text-blue-600 font-medium hover:underline"
            >
              <ChevronLeft size={20} /> Back
            </button>
          )}
          <div className="flex-1" />
          <div className="flex items-center gap-8 text-sm font-medium">
            {[
              { id: "branch", label: "Branch", completed: !!selectedBranch },
              { id: "datetime", label: "Date & Time", completed: !!date && !!selectedTime },
              { id: "info", label: "Your Info", completed: false },
            ].map((tab, i) => (
              <div key={tab.id} className="flex items-center gap-3">
                <div
                  className={`w-9 h-9 rounded-full flex items-center justify-center text-white font-bold text-xs
                    ${activeTab === tab.id ? "bg-blue-600" : tab.completed ? "bg-green-600" : "bg-gray-300"}`}
                >
                  {tab.completed ? <Check size={16} /> : i + 1}
                </div>
                <span className={activeTab === tab.id ? "text-blue-600 font-bold" : "text-gray-500"}>
                  {tab.label}
                </span>
                {i < 2 && <div className="w-16 h-0.5 bg-gray-300" />}
              </div>
            ))}
          </div>
          <div className="w-20" />
        </div>

        <div className="bg-white rounded-3xl shadow-xl p-10">

          {/* TAB 1: Branch */}
          {activeTab === "branch" && (
            <div className="max-w-2xl mx-auto">
              <h2 className="text-3xl font-bold text-center mb-10 flex items-center justify-center gap-3">
                <MapPin className="text-blue-600" /> Select Your Branch
              </h2>

              <div className="relative mb-8">
                <Search className="absolute left-4 top-4 text-gray-400" size={24} />
                <input
                  type="text"
                  placeholder="Search by name, city or suburb..."
                  value={search}
                  onChange={(e) => setSearch(e.target.value)}
                  className="w-full pl-14 pr-6 py-4 border-2 rounded-xl text-lg focus:outline-none focus:border-blue-500"
                />
              </div>

              {branchesLoading && (
                <div className="text-center py-16">
                  <RefreshCw className="w-10 h-10 text-blue-600 mx-auto animate-spin" />
                  <p className="mt-4 text-gray-600">Loading branches...</p>
                </div>
              )}

              {branchesError && (
                <div className="text-center py-16">
                  <AlertCircle className="w-16 h-16 text-red-500 mx-auto mb-4" />
                  <p className="text-red-600 font-medium mb-6">{branchesError}</p>
                  <button onClick={() => window.location.reload()} className="px-8 py-3 bg-red-600 text-white rounded-xl hover:bg-red-700">
                    Retry
                  </button>
                </div>
              )}

              {!branchesLoading && !branchesError && branches.length === 0 && (
                <p className="text-center py-16 text-gray-500">
                  {search ? "No branches found" : "Type to search branches"}
                </p>
              )}

              {!branchesLoading && !branchesError && branches.length > 0 && (
                <div className="space-y-4 max-h-96 overflow-y-auto">
                  {branches.map((b) => (
                    <BranchCard
                      key={b.id}
                      branch={b}
                      selected={selectedBranch?.id === b.id}
                      onClick={() => {
                        setSelectedBranch(b);
                        setDate(null);
                        setSelectedTime("");
                        setActiveTab("datetime");
                        setTimeout(scrollToTop, 100);
                      }}
                    />
                  ))}
                </div>
              )}
            </div>
          )}

          {/* TAB 2: Date & Time */}
          {activeTab === "datetime" && selectedBranch && (
            <div className="max-w-2xl mx-auto">
              <h2 className="text-3xl font-bold text-center mb-10 flex items-center justify-center gap-3">
                <Calendar className="text-blue-600" /> Select Date & Time
              </h2>

              <div className="bg-blue-50 p-6 rounded-2xl mb-10 text-center">
                <p className="text-2xl font-bold">{selectedBranch.branchName}</p>
                <p className="text-gray-700">{selectedBranch.address}, {selectedBranch.city}</p>
              </div>

              <div className="flex justify-center mb-12">
                <DatePicker
                  selected={date}
                  onChange={setDate}
                  minDate={new Date()}
                  maxDate={new Date(new Date().setMonth(new Date().getMonth() + 1))}
                  filterDate={(d) => !isDayDisabled(d)}
                  inline
                  calendarClassName="shadow-2xl border-2 border-gray-200 rounded-2xl"
                  dayClassName={(d) => isDayDisabled(d) ? "text-gray-300 line-through" : "hover:bg-blue-100"}
                />
              </div>

              {date && (
                <div>

                  <p className="text-center text-gray-600 mb-4">
                    Each time slot represents a {selectedBranch.slotDuration} minute appointment.
                  </p>
                  <h3 className="text-xl font-bold text-center mb-6 flex items-center justify-center gap-2">
                    <Clock /> Available Time Slots
                  </h3>

                  {slotsLoading && (
                    <div className="text-center py-12">
                      <RefreshCw className="w-10 h-10 text-blue-600 mx-auto animate-spin" />
                    </div>
                  )}

                  {slotsError && (
                    <div className="text-center py-12">
                      <AlertCircle className="w-12 h-12 text-orange-500 mx-auto mb-4" />
                      <p className="text-orange-700 font-medium">{slotsError}</p>
                    </div>
                  )}

                  {!slotsLoading && !slotsError && slots.length === 0 && (
                    <p className="text-center py-12 text-red-600 font-bold text-xl">
                      No available time slots for this date
                    </p>
                  )}

                  {!slotsLoading && !slotsError && slots.length > 0 && (
                    <div className="grid grid-cols-4 gap-4 max-w-2xl mx-auto">
                      {slots.map((slot) => (
                        <button
                          key={slot.time}
                          disabled={!slot.isAvailable}
                          onClick={() => slot.isAvailable && setSelectedTime(slot.time)}
                          className={`py-4 rounded-xl font-medium transition text-lg
                            ${selectedTime === slot.time
                              ? "bg-blue-600 text-white shadow-lg"
                              : slot.isAvailable
                              ? "bg-gray-100 hover:bg-blue-100"
                              : "bg-gray-200 text-gray-500 cursor-not-allowed"
                            }`}
                        >
                          {slot.time}
                        </button>

                      ))}
                    </div>
                  )}

                  {selectedTime && (
                    <div className="flex justify-center mt-12">
                      <button
                        onClick={() => {
                          setActiveTab("info");
                          setTimeout(scrollToTop, 100);
                        }}
                        className="flex items-center gap-2 px-8 py-3 bg-blue-600 text-white rounded-xl font-semibold hover:bg-blue-700 transition text-lg"
                      >
                        Continue <ChevronRight size={20} />
                      </button>
                    </div>
                  )}
                </div>
              )}
            </div>
          )}

          {/* TAB 3: Customer Info */}
          {activeTab === "info" && selectedBranch && date && selectedTime && (
            <div className="max-w-2xl mx-auto">
              <h2 className="text-3xl font-bold text-center mb-10 flex items-center justify-center gap-3">
                <User className="text-blue-600" /> Your Information
              </h2>

              <div className="bg-gray-50 p-6 rounded-2xl mb-10 text-center">
                <p className="font-bold text-xl">{selectedBranch.branchName}</p>
                <p className="text-lg">{format(date, "EEEE, dd MMMM yyyy")} at {selectedTime}</p>
              </div>

              {bookingError && (
                <div className="bg-red-50 border border-red-200 text-red-700 px-6 py-5 rounded-2xl text-center font-medium">
                  {bookingError}
                </div>
              )}

              <form onSubmit={handleSubmit(onSubmit)} className="space-y-6">
                <div>
                  <input {...register("fullName")} placeholder="Full Name" className="w-full px-5 py-4 border-2 rounded-xl text-lg focus:outline-none focus:border-blue-500" />
                  {errors.fullName && <p className="text-red-500 text-sm mt-1">{errors.fullName.message}</p>}
                </div>

                <div>
                  <input {...register("idNumber")} placeholder="ID Number (13 digits)" className="w-full px-5 py-4 border-2 rounded-xl text-lg focus:outline-none focus:border-blue-500" />
                  {errors.idNumber && <p className="text-red-500 text-sm mt-1">{errors.idNumber.message}</p>}
                </div>

                <div>
                  <input {...register("contactNumber")} placeholder="Mobile Number (082...)" className="w-full px-5 py-4 border-2 rounded-xl text-lg focus:outline-none focus:border-blue-500" />
                  {errors.contactNumber && <p className="text-red-500 text-sm mt-1">{errors.contactNumber.message}</p>}
                </div>

                <div>
                  <input {...register("email")} type="email" placeholder="Email Address" className="w-full px-5 py-4 border-2 rounded-xl text-lg focus:outline-none focus:border-blue-500" />
                  {errors.email && <p className="text-red-500 text-sm mt-1">{errors.email.message}</p>}
                </div>

                <div>
                  <textarea {...register("notes")} placeholder="Notes (optional)" rows={4} className="w-full px-5 py-4 border-2 rounded-xl text-lg focus:outline-none focus:border-blue-500" />
                </div>

                <div className="flex justify-center pt-8">
                  <button
                    type="submit"
                    disabled={isSubmitting}
                    className="px-12 py-4 bg-blue-600 text-white rounded-xl font-bold text-xl hover:bg-blue-700 disabled:opacity-70 disabled:cursor-not-allowed transition flex items-center gap-3"
                  >
                    {isSubmitting ? (
                      <>
                        <RefreshCw className="animate-spin" size={24} />
                        Booking...
                      </>
                    ) : (
                      "Confirm Appointment"
                    )}
                  </button>
                </div>
              </form>
            </div>
          )}
        </div>
      </div>
    </div>
  );
}