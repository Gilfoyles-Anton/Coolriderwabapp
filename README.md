# CoolRider Web Application

CoolRider is a comprehensive ASP.NET Core MVC web application project that demonstrates full-stack development practices, including secure authentication, database integration, responsive UI design, and interactive map features. This README provides a detailed overview of the project, its architecture, technologies, setup instructions, and development notes. The content is intentionally extensive (over 1500 words) so you can copy it directly into your GitHub repository as a complete README.

---

## Table of Contents
1. Introduction
2. Features
3. Tech Stack
4. Architecture Overview
5. Project Structure
6. Setup and Installation
7. Configuration
8. Database and Migrations
9. Running the Application
10. Maps Integrations
11. Deployment
12. Git and GitHub Workflow
13. Troubleshooting
14. Security Notes
15. Roadmap
16. Screenshots and Media
17. Contributing
18. License

---

## 1. Introduction

CoolRider is designed as a modern web application that leverages the power of ASP.NET Core MVC to deliver a secure, scalable, and user-friendly platform. It integrates multiple technologies to provide a complete development experience, including authentication, role management, database connectivity, and interactive maps. The project serves as both a learning resource and a foundation for building production-ready applications.

---

## 2. Features

- **Authentication & Authorization**
  - Supports multiple roles (User and Admin).
  - Secure password hashing and confirmation.
  - Role-based access control for different parts of the application.

- **Validation & Error Handling**
  - Uses DataAnnotations for model validation (`Required`, `StringLength`, `EmailAddress`, `Phone`, `Compare`).
  - Client-side validation with `_ValidationScriptsPartial`.
  - Clear error messages in English for accessibility.

- **Responsive UI**
  - Built with Bootstrap 5 for modern, responsive design.
  - Card-based layout with consistent styling.
  - Mobile-friendly and cross-browser compatible.

- **Interactive Maps**
  - Google Maps Standard Embed (no API key required).
  - Optional Satellite, Street View, and Directions (requires API key).
  - OpenStreetMap integration.
  - Bing Maps embedding.

- **Clean Layout**
  - `_Layout.cshtml` provides a unified layout with navigation bar and background image.
  - Consistent design across all pages.

- **Deployment Ready**
  - HTTPS enforced with HSTS in production.
  - Configurable via `appsettings.json`.
  - Static assets managed via `wwwroot`.

---

## 3. Tech Stack

| Layer              | Technology |
|--------------------|------------|
| Frontend           | HTML5, CSS3, Bootstrap 5, Razor Views |
| Backend            | ASP.NET Core MVC (C#) |
| Database           | SQL Server, Entity Framework Core |
| Authentication     | ASP.NET Identity, DataAnnotations |
| Maps API           | Google Maps Embed, OpenStreetMap, Bing Maps |
| Version Control    | Git & GitHub |
| Tooling            | .NET SDK, Visual Studio, Git Bash |

---

## 4. Architecture Overview

- **MVC Pattern**: Separation of concerns using Controllers, Models, and Views.
- **DbContext**: Centralized EF Core context for database access.
- **Routing**: Conventional routing with default controller/action/id pattern.
- **Static Assets**: Managed via `wwwroot` and `MapStaticAssets`.
- **Validation**: DataAnnotations in models with automatic wiring to views.

---

## 5. Project Structure

CoolRider-1/
├── CoolRider-1.sln
├── CoolriderDB.dacpac
├── Data/
│   └── ApplicationDbContext.cs
├── Models/
│   ├── RegisterModel.cs
│   └── LoginModel.cs
├── Controllers/
│   ├── HomeController.cs
│   ├── AccountController.cs
│   └── MapController.cs
├── Views/
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   └── _ValidationScriptsPartial.cshtml
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── Account/
│   │   ├── Login.cshtml
│   │   └── Register.cshtml
│   └── Map/
│       └── Index.cshtml
├── wwwroot/
│   ├── css/
│   │   └── site.css
│   ├── js/
│   │   └── site.js
│   └── images/
│       └── 1.jpg
├── appsettings.json
├── Program.cs
└── CoolRider_1.styles.css

## 6. Setup and Installation

### Prerequisites
- .NET 7+ SDK
- SQL Server
- Git and Git Bash
- Visual Studio or VS Code
