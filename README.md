# Employee Management MVC Application
A sample ASP.NET Core MVC CRUD application built for documentation generation and architecture analysis.
## Features
- Create Employee
- View Employees
- Edit Employee
- Delete Employee
- Entity Framework Core
- SQL Server
- Repository Pattern
- Service Layer
- MVC Architecture
## Technology Stack
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap
## Architecture
Controller
→ Service
→ Repository
→ Entity Framework Core
→ SQL Server
## Database
Employee
| Field | Type |
|--------|------|
| Id | int |
| Name | string |
| Email | string |
| Department | string |
| Salary | decimal |
## CRUD Endpoints
- GET /Employee
- GET /Employee/Create
- POST /Employee/Create
- GET /Employee/Edit/{id}
- POST /Employee/Edit
- GET /Employee/Delete/{id}
- POST /Employee/DeleteConfirmed
- GET /Employee/Details/{id}
