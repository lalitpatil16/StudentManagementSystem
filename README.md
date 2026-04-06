# Student Management System (Backend API)

## Project Overview
This is a backend REST API built using ASP.NET Core Web API.  
It provides secure CRUD operations for managing student data with JWT Authentication.

---

## Features
- Get all students  
- Add new student  
- Update student  
- Delete student  
- JWT Authentication  
- Global Exception Handling Middleware  
- Swagger API Documentation  
- Layered Architecture (Controller, Service, Repository)  

---

##  Tech Stack
- ASP.NET Core Web API  
- JWT Authentication  
- Swagger (OpenAPI)  
- Middleware for Exception Handling  

---

## Setup Instructions

## Prerequisites
- .NET SDK installed  
- Visual Studio / VS Code  

### Steps to Run
1. Clone the repository  
2. Open the project in Visual Studio  
3. Build the solution  
4. Run the application  

---

## Authentication

### Get Token
POST /api/auth/login

### Use Token
Click **Authorize** in Swagger and enter:
Bearer YOUR_TOKEN

---

## API Endpoints

GET    /api/student        -> Get all students  
POST   /api/student        -> Add student  
PUT    /api/student        -> Update student  
DELETE /api/student/{id}   -> Delete student  

---

## Project Structure

Controllers/  
Services/  
Repositories/  
Models/  
Middleware/  

