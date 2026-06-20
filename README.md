# GymMS — Gym Management System

A concise, practical README for the GymMS project (Gym Management System) implemented in C# (.NET).

## Project
GymMS is a lightweight backend for managing gym operations: members, trainers, class types, scheduled sessions, subscriptions, attendance, and basic reporting.

## Features
- Member, trainer, class, schedule, subscription, payment, and attendance management
- Role-based access (Admin / Staff / Trainer / Member)
- REST API built with C# / ASP.NET Core
- Persistence via Entity Framework Core (migrations supported)

## Tech stack
- Language: C# (.NET)
- Web: ASP.NET Core (Web API)
- ORM: Entity Framework Core
- Database: PostgreSQL / SQL Server / SQLite (configurable)
- Container: Docker (optional)

## Quickstart
Prerequisites: .NET SDK (6+ recommended), Docker (optional), a relational DB.

1. Clone
   git clone https://github.com/GayathriHubb/Repo39-GymMS.git
   cd Repo39-GymMS

2. Restore & build
   dotnet restore
   dotnet build

3. Configure database
- Copy any provided sample config (appsettings.Development.json or .env template) and set your connection string.
- If the project uses EF Core migrations:
   dotnet ef database update

4. Run
   dotnet run --project ./src/YourApiProjectName

(Replace `./src/YourApiProjectName` with the actual API project path; check the solution (.sln) root for project names.)





Refer to the controller classes in the project to see exact routes and request/response shapes.

## Data model (core entities)
- Member
- Trainer
- Class (class type)
- Session / Schedule
- Subscription
- Payment
- Attendance

## Tests
- Run unit and integration tests with:
   dotnet test

## Contributing
1. Fork
2. Create a branch: git checkout -b feat/your-feature
3. Implement change and tests
4. Open a PR describing intent and testing steps

## License
MIT — see LICENSE in repository.

## Maintainer
GayathriHubb — https://github.com/GayathriHubb/Repo39-GymMS
