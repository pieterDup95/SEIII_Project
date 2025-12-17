# Appointment Booking System

This repository contains a full-stack Appointment Booking System, consisting of two main components:

- **appointment-scheduler**: The frontend application (built with React, Vite, and Tailwind CSS)
- **appointment-service**: The backend service (built with ASP.NET Core Web API and Entity Framework Core)

## Table of Contents
- [Overview](#overview)
- [Architecture](#architecture)
- [Features](#features)
- [Project Description](#project-description)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Environment Variables](#environment-variables)
  - [Running the Application (Recommended)](#running-the-application-recommended)
  - [Manual Local Development (Optional)](#manual-local-development-optional)
- [Testing](#testing)
- [Project Structure](#project-structure)
- [Development Setup](#development-setup)
- [Production Setup](#production-setup)
  

---

## Overview

The Appointment Booking System allows users to schedule appointments through a modern, responsive web interface. The system is designed for scalability and maintainability, with a clear separation between frontend and backend services.

## Architecture

- **Frontend**: `appointment-scheduler` (React + Vite + Tailwind CSS, served via Nginx in production mode)
- **Backend**: `appointment-service` (ASP.NET Core Web API with Entity Framework Core)
- **Database**: PostgreSQL (persistent data storage)
- **Migrations & Seeding**: A dedicated one-time migration service that applies EF Core migrations to create/update the database schema and seeds initial data
- **Communication**: RESTful API (frontend proxies `/api` requests to the backend)
- **Containerization**: Docker & Docker Compose for orchestrating all services

The Docker Compose setup includes:
- `db`: PostgreSQL database with health checks
- `migrate`: Runs once to apply database migrations and seed data (depends on a healthy database)
- `api`: The backend API (depends on successful migration)
- `frontend`: The React application (depends on the API)

## Features

- User-friendly appointment scheduling UI
- Create, view, and manage appointments
- Responsive design for desktop and mobile
- Secure backend API with authentication support
- Database persistence via PostgreSQL
- Automated schema migrations and initial data seeding


---

## Project Description

This Appointment Booking System is a full-stack application designed to simulate a realistic, production-like booking experience for a multi-branch organization.

### Security & API Access

- **Public APIs** (used by the frontend): Protected endpoints that allow booking, viewing available slots, and checking existing appointments. These are accessible only from the frontend via a secure frontend-specific token mechanism.
- **Management APIs**: A dedicated `ManagementController` provides administrative functionality restricted to a separate "management" client. These endpoints allow:
  - Adding and managing branches
  - Defining operational hours per branch
  - Configuring public holidays (which affect availability across branches)

These management endpoints are intentionally separated to reflect real-world role-based access patterns.

### Database & Startup Flow

The backend connects to a **PostgreSQL** database for persistent storage.

When you run `docker-compose up --build`:
1. The `db` service starts PostgreSQL with a health check.
2. The `migrate` service waits for the database to be healthy, then:
   - Applies all Entity Framework Core migrations to create/update the schema
   - Seeds the database with realistic dummy data (branches, operational hours, holidays, etc.)
3. Only after successful migration does the `api` (backend) service start.
4. Finally, the `frontend` service starts.

This dependency chain ensures the database is fully initialized and populated before the application becomes available — providing an immediate, testable experience with realistic data.

### Frontend Experience

The frontend is more than just a booking form — it includes a small informational website (home page, about, services) to create a fuller, more realistic user journey.

**Booking Flow**:
1. **Select a branch** – Search and choose from available branches.
2. **Choose a date** – A calendar view shows:
   - Dates when the branch is closed (e.g., holidays or non-operational days) are greyed out and crossed through.
3. **Select a time slot** – Available slots appear based on branch operational hours.
Each branch has a configurable capacity called AppointmentsPerSlot in the Branch table.
This is a very important feature that lets bigger branches handle more customers at the same time:

   - If AppointmentsPerSlot = 1 → the slot becomes unavailable (greyed out) immediately after one person books it
   - If AppointmentsPerSlot = 5 → the slot stays open and bookable until 5 different people have booked it – then it turns grey and cannot be selected anymore
     
    This makes the system realistic for both small branches (one customer at a time) and large branches with more staff/resources (multiple appointments in the same slot).

4. **Enter personal details**:
   - Name, South African ID number (validated to exactly 13 digits), phone number, and email are required.
   - The ID number is used to enforce a **one active appointment per person** rule.
     - If a user with the same ID already has a booking, a clear popup informs them they must cancel the existing one first.
5. **Confirmation**:
   - On successful booking, a popup displays a reference number and confirmation message.
   - The system is designed to trigger SMS and email notifications.

**Note on Notifications**:
- The backend queues confirmation messages to **AWS SQS**, which would normally trigger a Lambda to forward them via **AWS SNS** for SMS/email delivery.
- Additionally, direct integration with **SendGrid** (via NuGet package) is implemented as an alternative email-sending mechanism.
- However, since this uses a personal AWS free-tier account and a free SendGrid account, actual SMS and emails are **not sent** — recipient phone numbers and emails must be pre-verified, which isn't feasible in a demo.
- These services are fully wired in the code to demonstrate how real-world notification delivery would be implemented using organizational infrastructure.

**Error Handling**:
- The frontend gracefully handles API failures with user-friendly error messages and popups, ensuring a robust user experience even when something goes wrong.

This design reflects production-grade considerations: separation of concerns, realistic data flow, capacity management, validation, security, and observability through queued notifications.


---
## Getting Started

### Prerequisites
- [Docker](https://www.docker.com/) & [Docker Compose](https://docs.docker.com/compose/)
- [Node.js](https://nodejs.org/) (for frontend development)
- [.NET 8 SDK](https://dotnet.microsoft.com/) (for backend development)

### Environment Variables
A ready-to-use `.env` file is already included in the repository with default values:

```env
POSTGRES_USER=your_postgres_user
POSTGRES_PASSWORD=your_secure_password
POSTGRES_DB=appointment_db
```
These credentials allow you to run the application immediately after cloning without any additional configuration.
> **Note:** In a real production environment, you should change these to strong, unique values and never commit them to version control.

### Running the Application (Recommended)
The easiest and most reliable way to run the full application is using Docker Compose. This starts the PostgreSQL database, applies migrations and seeds data, launches the backend API, and serves the frontend.

1. **Clone the repository:**
    ```bash
    git clone <repo-url>
    cd Appointment-Booking-System
    ```
2. Build and start all services:
    ```bash
    docker-compose up --build
    ```
    The first run will take a few minutes as it builds the Docker images. Subsequent starts will be faster.
    Docker Compose will automatically:
    - Start the PostgreSQL database (db)
    - Wait until the database is ready (via health check)
    - Run the one-time migration container (migrate) to apply EF Core migrations, create the schema, and seed initial data
    - Start the backend API (api)
    - Serve the frontend (frontend)

3. Access the application:
       
    **Frontend:** http://localhost:5173
    
    **Backend API:** http://localhost:5000

4. To stop the application:
    ```sh
    docker-compose down
    ``` 
    Add --volumes if you want to remove the persistent database data:
    ```sh
    docker-compose down --volumes
    ```

### Manual Local Development (Optional)
If you prefer to run the frontend or backend directly on your machine (e.g., for debugging or faster iteration):
#### Frontend (appointment-scheduler)

Install dependencies:
```bash
cd Appointment-Booking-System/appointment-scheduler
npm install
npm run dev
``` 
The frontend will be available at http://localhost:5173 with hot reload enabled.

#### Backend (appointment-service)

1. Ensure a PostgreSQL instance is running locally with the same credentials as in .env (or update the connection string in appointment-service/appointment-service/appsettings.json).
2. Apply migrations (if not already done via Docker):
    ```bash
    cd Appointment-Booking-System/appointment-service/appointment-service
    dotnet ef database update
    ```
3. Run the API:
    ```bash
    dotnet run
    ```

---
## Testing
### Frontend Tests

The frontend uses **Vitest** and **React Testing Library** for fast, reliable component and interaction testing.

To run the tests:

```sh
cd Appointment-Booking-System/appointment-scheduler
npm run test
```


### Backend Tests
```sh
cd Appointment-Booking-System/appointment-service/appointment-service.Tests
dotnet test
```

---

## Project Structure
```bash
Appointment-Booking-System/
├── appointment-scheduler/         # Frontend (React)
│   ├── src/
│   ├── public/
│   └── Dockerfile
├── appointment-service/           # Backend (ASP.NET Core)
│   ├── appointment-service/       # Main API project (with EF Core migrations)
│   ├── appointment-service.Tests/ # Unit tests
│   └── Dockerfile
├── docker-compose.yml             # Orchestrates db, migrate, api, and frontend services
└── .env                           # Environment variables (gitignored)
```

---

### Development Setup
```bash
[Browser] <--HTTP--> [Vite Dev Server] <--API--> [ASP.NET Core Backend]
       ^                 ^
       |                 |
   Hot reload          Serves React app dynamically
```
- Vite dev server runs React with hot reload.
- API requests go directly to the backend.
- Tailwind CSS styles are applied in real-time.


### Production Setup
```bash
[Browser] <--HTTP/HTTPS--> [Nginx] <---> [ASP.NET Core Backend]
       |
       v
  Serves static files
(React build from Vite)
```

- Vite builds optimized static files in `/dist`.
- Nginx serves static files and proxies API requests to the backend.
- Vite is not running in production.
