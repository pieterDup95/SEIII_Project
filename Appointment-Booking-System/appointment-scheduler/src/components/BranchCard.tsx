import { MapPin, Phone } from "lucide-react";
import type { Branch } from "../types";

interface Props {
  branch: Branch;
  selected: boolean;
  onClick: () => void;
}

export default function BranchCard({ branch, selected, onClick }: Props) {
  return (
    <div
      onClick={onClick}
      className={`p-6 rounded-xl border-2 cursor-pointer transition-all hover:shadow-md ${
        selected
          ? "border-blue-600 bg-blue-50 shadow-lg"
          : "border-gray-200 hover:border-gray-400"
      }`}
    >
      <h3 className="text-xl font-bold text-gray-900">{branch.branchName}</h3>

      <div className="mt-3 space-y-2 text-sm text-gray-600">
        <p className="flex items-center gap-2">
          <MapPin size={16} />
          {branch.city} — {branch.address}
        </p>
        <p className="flex items-center gap-2">
          <Phone size={16} />
          {branch.contactNumber}
        </p>
      </div>

    </div>
  );
}