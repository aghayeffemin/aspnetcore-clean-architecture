# ASP.NET Core Web API Clean Architecture

This repository is about implementing Clean aka Onion architecture with ASP.NET Core

## Development Process

You can follow the development process via commit messages

- created solution and projects
- added entity model and dbcontext
- added database related changes
- added repositories
- added user queries
- added commands
- test project setup
- added first test class and method

## Setup

- SQLite has been used as database
- You can change connection string from *appsettings.json* within *aspnetcore-clean-architecture.API*
- Apply database migrations to create the tables. From a command line :

Go into aspnetcore-clean-architecture.Persistence class library
```
cd aspnetcore-clean-architecture.Persistence
```
Add migrations (Note: Migrations already exists here)
```
dotnet ef --startup-project ../aspnetcore-clean-architecture.API migrations add AddedTables --context AppDbContext
```
Apply database changes. If you are using SQLite then database file with .db extension should be created inside aspnetcore-clean-architecture.API project
```
dotnet ef --startup-project ../aspnetcore-clean-architecture.API database update AddedTables --context AppDbContext
```
## Layers

- aspnetcore-clean-architecture.API - Presentation Layer *.Net Core Web API project*.
- aspnetcore-clean-architecture.Application - This layer is responsible for *application logic*.
- aspnetcore-clean-architecture.Domain - This layer has database entities
- aspnetcore-clean-architecture.Persistence - Contains logic responsible for data access operations.
- aspnetcore-clean-architecture.Test - Unit Test will be added to this layer.

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## Show your support

Give a ⭐️ if this project helped you!
