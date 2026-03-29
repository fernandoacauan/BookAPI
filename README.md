# BookAPI - Web API

A robust and scalable Bookstore Management API built with **.NET 8**, following **Clean Architecture** principles. This project manages Authors and Books.

---

## Technologies

* **.NET 8** (ASP.NET Core Web API)
* **Entity Framework Core** (Object Relational Mapping)
* **SQL Server** (Database)
* **AutoMapper** (Object-to-object mapping)
* **FluentValidation** (Business rule validation)
* **Serilog** (Structured logging)
* **Swagger/OpenAPI** (API Documentation)
* **Docker** (Containerization)

---

## Architecture & Patterns

This project is organized into four main layers to ensure maintainability and testability:

1.  **Domain:** Contains Entities and Interfaces.
2.  **Application:** Contains DTOs, Mappings (AutoMapper), Validations (FluentValidation), and Use Cases.
3.  **Infrastructure:** Data context (EF Core), Repository implementations, and external services.
4.  **Presentation:** Web API Controllers and Program.cs.

---

## Setup and Installation

### Prerequisites
* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* [Docker](https://www.docker.com/)
