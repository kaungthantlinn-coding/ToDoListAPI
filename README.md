# ToDoListAPI.API
A To-Do List API built with ASP.NET Core Web API, utilizing Entity Framework Core (EF Core), Repository Pattern, and Middleware for structured exception handling and logging.

# 🚀 Features
- ✅ CRUD operations for To-Do items
- 🔒 Secure API with JWT Authentication
- 📦 Repository & Service layers for separation of concerns

- 🛠 Middleware for exception handling and request logging

- 💾 Uses Entity Framework Core with SQL Server

- 📊 Swagger UI for API testing

# 🛠️ Technologies Used
- ASP.NET Core Web API

- Entity Framework Core (EF Core)

- SQL Server

- Swagger UI

- Middleware for Exception Handling & Logging


## Installation

1.Clone the Repository

```bash
  git clone https://github.com/your-username/ToDoListAPI.git
  cd ToDoListAPI
```
2.Install Required Packages

```bash
  dotnet restore
```

3.Modify appsettings.json with your SQL Server connection string:
```bash
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=ToDoDb;Trusted_Connection=True;"
}
```

4.Apply Migrations & Seed Database

```bash
  dotnet ef migrations add InitialCreate
  dotnet ef database update
```

5.Run the API
```bash
  dotnet run
```

6.Test with Swagger UI
- Visit: http://localhost:5000/swagger

## 🛠️API Endpoints

| Method | Endpoint          | Description                     |
|--------|-------------------|---------------------------------|
| GET    | `/api/todo`      | Get all To-Do items            |
| GET    | `/api/todo/{id}` | Get a To-Do item by ID         |
| POST   | `/api/todo`      | Create a new To-Do item        |
| PUT    | `/api/todo/{id}` | Update a To-Do item            |
| DELETE | `/api/todo/{id}` | Delete a To-Do item            |


## 🔧Middleware

### ExceptionHandlingMiddleware.cs
Handles global exceptions and returns structured error responses.

### RequestLoggingMiddleware.cs
Logs all incoming HTTP requests.

To use, ensure these middlewares are added in `Program.cs`:

```csharp
 app.UseMiddleware<ExceptionHandlingMiddleware>();
 
```
# 🧪 Running Tests

```csharp
 dotnet test
```









    
