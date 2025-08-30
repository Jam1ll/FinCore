# FinCore: Online Banking Management System

## Project Description
**FinCore** is an online banking management system designed to efficiently handle financial operations for clients, administrators, and tellers. The application facilitates transactions, savings account management, loans, and credit cards through a robust and scalable architecture.

## Key Features
* **User Management**: Functionalities for Administrator, Client, and Teller roles.
* **Account Management**: Creation, viewing, and management of savings accounts.
* **Transactions**: Execution of deposits, withdrawals, and transfers between accounts.
* **Loan Management**: Application for loans and tracking of their status.
* **Credit Cards**: Control of credit limits, transaction history, and cash advances.
* **Beneficiary Management**: Clients can manage their lists of beneficiaries for quick transfers.

---

## Technologies Used
* **Backend**: C# and **ASP.NET Core** (ASP.NET Core MVC)
* **Databases**: SQL Server (via Entity Framework)
* **ORM**: **Entity Framework (Code First)**
* **Architecture**: **ONION Architecture**, **CQRS** (Command and Query Responsibility Segregation), and **Mediator**
* **Authentication**: JWT (JSON Web Tokens)
* **Validation**: FluentValidation
* **API Documentation**: Swagger
* **Front-end**: HTML, CSS, Bootstrap, JavaScript
* **DevOps**: Git, GitHub Actions

---

## Project Structure
The project follows a strict **ONION Architecture** to ensure separation of concerns and code modularity. The layers include:
* **Domain**: Entities and business logic.
* **Application**: Commands, queries, and handlers (implementing CQRS and Mediator).
* **Infrastructure**: Implementation of generic repositories, data services, and persistence logic with **Entity Framework Code First**.
* **Presentation (Web)**: API endpoints and the user interface.

---
