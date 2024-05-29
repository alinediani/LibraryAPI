# Library.API

## Description

Library.API is an API developed with .NET Core 6 that implements a library management system. The project utilizes various technologies and patterns, including CQRS, SQL Server, Migrations, Entity Framework Core, Fluent Validation, Clean Architecture, and Repository Pattern.

## Features

- **Add a Book**: Allows the registration of new books in the system.
- **Validate Data**: Uses Fluent Validation to ensure data integrity.
- **Get All Books**: Retrieves all registered books.
- **Get a Book**: Retrieves a specific book by its ID.
- **Remove a Book**: Allows the removal of books from the system.
- **Register a User**: Allows the registration of new users.
- **Register a Loan**: Allows recording book loans for users.

## Technologies Used

- **.NET Core 6**: Development platform for building modern, scalable, and high-performance applications.
- **CQRS (Command Query Responsibility Segregation)**: Pattern to separate reading and writing operations.
- **SQL Server**: Relational database used to store the application's data.
- **Migrations**: Entity Framework Core tool for managing database schema changes.
- **Entity Framework Core (EF Core)**: ORM for .NET Core that simplifies object-table mapping.
- **Fluent Validation**: Library for fluent data validation.
- **Clean Architecture**: Architecture pattern that promotes separation of concerns and facilitates maintenance and evolution of the system.
- **Repository Pattern**: Pattern that abstracts data access logic, promoting cleaner and more testable code.

## Prerequisites

- .NET SDK 6.0
- SQL Server

## Setup and Execution

1. **Clone the repository:**

    ```bash
    git clone https://github.com/alinediani/Library.API.git
    cd Library.API
    ```

2. **Configure the connection string to SQL Server:**

    Open the `appsettings.json` file and adjust the connection string as necessary:

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=YOUR_SERVER;Database=LibraryDB;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
    }
    ```

3. **Run the migrations to create the database:**

    ```bash
    dotnet ef database update
    ```

4. **Start the application:**

    ```bash
    dotnet run
    ```

    The application will be available at `http://localhost:7244`.

## Project Structure

- **Library.API**: Main API project.
- **Library.Application**: Contains application logic, including CQRS commands and queries.
- **Library.Core**: Contains domain entities and repository interfaces.
- **Library.Infrastructure**: Repository implementations, EF Core context, and Fluent Validation configurations.

## Endpoints

### Books

- **POST /api/books**: Add a new book.
- **GET /api/books**: Get all books.
- **GET /api/books/{id}**: Get a specific book.
- **DELETE /api/books/{id}**: Remove a book.

### Users

- **POST /api/users**: Register a new user.

### Loans

- **POST /api/loans**: Register a new loan.

## Contribution

1. Fork the project.
2. Create a branch for your feature (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

## License

Distributed under the MIT License. See `LICENSE` for more information.

## Contact

Aline Diani Batista - https://www.linkedin.com/in/alinedbatista/ - alinediani99@gmail.com

Project Link: [https://github.com/alinediani/Library.API](https://github.com/alinediani/Library.API)

---

This README provides an overview of the Library.API project, including its features, technologies used, setup and execution instructions, project structure, available endpoints, and information on how to contribute to the project.
