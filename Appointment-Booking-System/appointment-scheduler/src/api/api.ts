// src/api/api.ts
import type {
  Branch,
  BranchAvailability,
  CreateAppointmentRequest,
  AppointmentResponse,
} from "../types";

// ======================== CONFIG ========================
const API_BASE = "/api";//import.meta.env.VITE_API_BASE ;
const TOKEN_ENDPOINT = "/api/auth/frontend-token";//import.meta.env.VITE_TOKEN_ENDPOINT ;
 

if (!API_BASE || !TOKEN_ENDPOINT) {
  throw new Error("Missing required environment variables ");
}

// ======================== TOKEN MANAGER ========================
interface CachedToken {
  token: string;
  expiresAt: number;  
}

let cachedToken: CachedToken | null = null;

const getToken = async (): Promise<string> => {
  if (cachedToken && cachedToken.expiresAt > Date.now() + 30_000) {
    return cachedToken.token;
  }
alert(`${API_BASE}${TOKEN_ENDPOINT}`);
  const response = await fetch(`${API_BASE}${TOKEN_ENDPOINT}`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
  });

  if (!response.ok) {
    throw new Error("Failed to get token from server");
  }

  const data = await response.json();

  cachedToken = {
    token: data.access_token,
    expiresAt: Date.now() + (data.expires_in || 720 * 60) * 1000,
  };

  return cachedToken.token;
};

// ======================== MAIN  WRAPPER ========================
const apiFetch = async (endpoint: string, options: RequestInit = {}) => {
  const token = await getToken();

  const response = await fetch(`${API_BASE}${endpoint}`, {
    ...options,
    headers: {
      "Content-Type": "application/json",
      Authorization: `Bearer ${token}`,
      ...options.headers,
    },
  });

  let body: any = null;
  try {
    body = await response.json();
  } catch {
    // ignore JSON parse errors
  }

  if (!response.ok) {
    const error: any = new Error(body?.message || response.statusText);
    error.status = response.status;
    error.body = body;
    throw error;
  }

  return body;
};

// ======================== API  ========================
export const getBranches = async (search = ""): Promise<Branch[]> => {
  const params = search ? `?search=${encodeURIComponent(search)}` : "";
  return apiFetch(`/BranchDetail/branches${params}`);
};

export const getAvailability = async (
  branchId: string,
  date: string
): Promise<BranchAvailability> => {
  return apiFetch(`/Availability/${branchId}/availability?date=${date}`);
};

export const createAppointment = async (
  data: CreateAppointmentRequest
): Promise<AppointmentResponse> => {
  return apiFetch("/Appointments/create", {
    method: "POST",
    body: JSON.stringify(data),
  });
};

export const invalidateToken = () => {
  cachedToken = null;
  console.log("Token cache cleared");
};