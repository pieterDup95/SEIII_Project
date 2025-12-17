import { useState, useCallback } from "react";

type ApiState<T> =
  | { status: "idle" }
  | { status: "loading" }
  | { status: "success"; data: T }
  | { status: "error"; error: string };

export function useApi<T>() {
  const [state, setState] = useState<ApiState<T>>({ status: "idle" });

  const execute = useCallback(async (promise: Promise<T>, fallbackError = "Something went wrong") => {
    setState({ status: "loading" });
    try {
      const data = await promise;
      setState({ status: "success", data });
      return data;
    } catch (err: any) {
      const message =
        err?.message?.includes("API Error")
          ? err.message.split(":")[1]?.trim() || "Server error"
          : err?.message || fallbackError;

      setState({ status: "error", error: message });
      console.error("API Error:", err);
      throw err; // re-throw so components can handle it
    }
  }, []);

  return { ...state, execute, isLoading: state.status === "loading" };
}