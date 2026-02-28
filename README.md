🏗️ TechBooks Publishing Management System
Entity Framework Core + Onion Architecture + AutoFac + Mapster

A modern Console Application for managing authors and books using clean architecture principles and enterprise-level patterns.

📌 Overview

This project implements a publishing management system that handles:

Authors

Books

Relationships between them

Each:

Author can write many books

Book belongs to one author

Built using:

Clean Onion Architecture

Entity Framework Core (Code First)

Repository Pattern

Service Layer Pattern

Dependency Injection with AutoFac

Object Mapping with Mapster

🧅 Architecture

The solution follows Onion Architecture with strict separation of concerns.

Presentation
    ↓
Application (Services, DTOs, Interfaces)
    ↓
Domain (Entities)
    ↓
Infrastructure (EF Core, Repositories)
📁 Project Structure
TechBooksManagement
│
├── Domain
│   └── Entities
│       ├── Author.cs
│       └── Book.cs
│
├── Application
│   ├── DTOs
│   ├── Interfaces
│   │   ├── Repositories
│   │   └── Services
│   └── Services
│
├── Infrastructure
│   ├── Data
│   │   └── ApplicationDbContext.cs
│   └── Repositories
│
└── Presentation
    └── Console Application
🧩 Database Design
Author
Field	Type
AuthorId	int
FirstName	string
LastName	string
Phone	string
Books	ICollection<Book>
Book
Field	Type
BookId	int
Title	string
Price	decimal
PublishDate	DateTime
AuthorId	int
Author	Author
⚙️ Features
Author Management

Create author

Update author

Delete author

Get all authors

Get author by ID

Get author with books

Book Management

Create book

Update book

Delete book

Get all books

Get book by ID

Get books by author

🎯 Design Patterns Used

Onion Architecture

Repository Pattern

Generic Repository (optional)

Service Layer

Dependency Injection

DTO Mapping

📦 Required NuGet Packages

Install from Package Manager Console:

Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Autofac
Install-Package Mapster
🛠️ Database Setup (Code First)
Create Migration
Add-Migration InitialCreate
Update Database
Update-Database
▶️ How to Run

Clone repository

git clone <repo-url>

Open solution in Visual Studio

Update connection string in DbContext

Run migrations

Start console app

🧪 Sample Test Data
Authors
101  John Smith      408-555-1234
102  Sarah Johnson   415-555-5678
Books
C# Programming Guide        49.99
Advanced Entity Framework   59.99
Design Patterns in C#       45.00
✅ Suggested Testing

Add authors

Add books

View authors with book count

View books with author name

Update book price

Delete book

Try deleting author with books

🔑 Why Service Layer?

Business validation

Clean UI logic

Testable code

Reusable logic

Mapping control

💡 Key Learning Outcomes

Clean architecture design

EF Core relationships

Dependency injection

Mapping DTOs

Layered application structure

👩‍💻 Author

Developed as part of EF Core + Clean Architecture lab.
