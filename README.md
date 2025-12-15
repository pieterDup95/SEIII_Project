# Appointment Booking System

This repository contains a full-stack Appointment Booking System, consisting of two main components:

- **appointment-scheduler**: The frontend application (built with React, Vite, and Tailwind CSS)
- **appointment-service**: The backend service (built with ASP.NET Core Web API and Entity Framework Core)

## Table of Contents
- [Overview](#overview)
- [Architecture](#architecture)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Environment Variables](#environment-variables)
  - [Running with Docker Compose](#running-with-docker-compose)
  - [Manual Setup](#manual-setup)
- [Project Structure](#project-structure)
- [Development](#development)

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

## Getting Started

### Prerequisites
- [Docker](https://www.docker.com/) & [Docker Compose](https://docs.docker.com/compose/)
- [Node.js](https://nodejs.org/) (for frontend development)
- [.NET 8 SDK](https://dotnet.microsoft.com/) (for backend development)

### Environment Variables

Create a `.env` file in the root directory (next to `docker-compose.yml`) with the following:

```env
POSTGRES_USER=your_postgres_user
POSTGRES_PASSWORD=your_secure_password
POSTGRES_DB=appointment_db
```
These variables are used by the PostgreSQL container and propagated to the migration/backend services.


### Running with Docker Compose
Recommended for full-stack development and production-like setup.

1. **Clone the repository:**
```bash
git clone <repo-url>
cd Appointment-Booking-System
```
2. Create the .env file as described above.
3. Start all services:
```bash
docker-compose up --build
```
Docker Compose will:
- Start the PostgreSQL database (db)
- Wait for the database to be healthy
- Run the migration service (migrate) to apply EF Core migrations, create the schema, and seed initial data
- Start the backend API (api)
- Start the frontend (frontend)

4. Access the application:
Frontend: http://localhost:5173
Backend API: http://localhost:5000
To stop: docker-compose down (add --volumes to remove persistent database data).

### Manual Setup
## Frontend (appointment-scheduler)

Install dependencies:
```bash
cd Appointment-Booking-System/appointment-scheduler
npm install
```
Start the development server:`npm run dev`

## Backend (appointment-service)

Ensure PostgreSQL is running locally (or update the connection string in appsettings.json).
Apply migrations manually (if needed):
```bash
cd Appointment-Booking-System/appointment-service/appointment-service
dotnet ef database update
```
Build and run: `dotnet run`


### Project Structure
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

