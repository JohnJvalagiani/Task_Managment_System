# Task Management System

## Summary

The Task Management System is a RESTful API developed using ASP.NET Core 7.0. Its primary function is to facilitate the management of tasks, allowing for functionalities such as task creation, editing, and deletion. The application incorporates ASP.NET Core Identity for user authentication and role management, enabling administrators to add new users and assign roles and permissions like `Task_Create`, `Task_Update`, and `Task_Delete`. Depending on their assigned permissions, users are able to perform specific actions on tasks.

## Features

- The administrator has the authority to add new users to the system.
- Users can be assigned specific roles and permissions by the administrator.
The permissions determine the range of actions a user can perform, including:
- Creating a task
- Editing a task
- Deleting a task
- Viewing tasks

## Technologies Used

- **ASP.NET Core**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **AutoMapper**
- **Swagger**
- **.NET 7.0**

## Modules

The project is structured into several modules:
- **Server**: Main API host.
- **Dtos (Data Transfer Objects)**: DTOs for data transactions.
- **Infrastructure**: Database and other infrastructural elements.
- **Domain**: Domain entities and logic.
- **Application**: Application-specific logic.





## Installation and Running Locally



### Prerequisites

Make sure you have .NET 7.0 SDK and Entity Framework Core CLI installed.
### Setup Database


Open the project in Visual Studio.
Set Task_Management_System.Server as the startup project.
Open the Package Manager Console and run the command Update-Database.

Login with the default admin account:
- Email: admin@example.com
- Password: Admin@123
