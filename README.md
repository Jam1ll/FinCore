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

## Getting Started

### Prerequisites
Make sure you have the following installed:
* .NET SDK (version 8.0 or later)
* SQL Server
* Docker (optional, for the MongoDB database)
* Visual Studio or Visual Studio Code

### Local Setup
1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/Jamil-20240100/FinCore.git](https://github.com/Jamil-20240100/FinCore.git)
    cd FinCore
    ```
2.  **Configure the database:**
    * Update the connection string in the `appsettings.json` or `appsettings.Development.json` file to point to your SQL Server instance.
    * Apply the Entity Framework migrations:
    ```bash
    dotnet ef database update
    ```
3.  **Run the application:**
    ```bash
    dotnet run --project [your-web-project-name]
    ```
    The application will run at `https://localhost:[port]`.

---

## API Documentation
The project's API is documented with Swagger. Once the application is running, you can access the Swagger UI to test the endpoints at the following URL:
`https://localhost:[port]/swagger`

---

## Contributions
Contributions are welcome! If you want to contribute, please clone this repository, create a branch for your feature (`git checkout -b feature/your-feature-name`), make your changes, and submit a Pull Request.

## License
This project is licensed under the MIT License.
