    Book Management API
A simple RESTful API built with ASP.NET Core 7 and Entity Framework Core, using an in-memory database to manage books.
Features
•	Full CRUD operations for book management:
  o	Retrieve all books.
  o	Retrieve a single book by ID.
  o	Add, update, and delete books.
•	Built with ASP.NET Core 7.
•	Uses Entity Framework Core with an in-memory database (no external database setup required).
•	JSON-based responses.
•	Interactive API documentation with Swagger.

Getting started
Installation 
•	Clone this repository
•	Restore NuGet Packages
Running the application
•	Build the project: dotnet build
•	Start the application: dotnet run
•	The API accessible at: http:// localhost:5000

 

Dependencies
1.	Microsoft.EntityFrameworkCore: Entity Framework Core ORM.
2.	Microsoft.EntityFrameworkCore.InMemory: In-memory database provider for testing and lightweight use.
3.	Swashbuckle.AspNetCore: Swagger for API documentation.

Notes
•	This project uses an in-memory database, so all data will be cleared when the application stops.
•	For production, replace the in-memory database with a persistent database such as SQL Server or PostgreSQL.

