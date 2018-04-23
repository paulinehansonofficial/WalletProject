# Digital Wallet Project

## Getting Started
Download and install .NET Core for your platform:
https://www.microsoft.com/net/learn/get-started

Download and install bower:
https://bower.io/

Run `bower install` from the project directory to get all the web dependencies for the project (Bootstrap, jQuery, etc.). 

Run the database migrations to create a local SQLite database:
```
dotnet ef database update
```

> *Pro tip:*
> To inspect the contents of the database, install SQLite explorer or the SQLite3 Command Line tools:
> https://www.sqlite.org/cli.html
> http://sqlitebrowser.org/

Run the application with the following command:
```
cd DigWalProj
dotnet run
```
> Note: this will run the SeedData script (found under ` Models/SeedData.cs`) to provide you with some test data for the system.

## Sharing updates to the database 
If you are making changes to the model classes (any model class under `Models/*.cs`) or the database context (`Models/AccountContext.cs`), the database can be updated by generating a *migration* for the change.

To add a migration for your model changes, run the following command:
```
dotnet ef migrations add [Name of your migration] 
```

This will generate and modify the necessary files under the `Migrations` folder to facilitate a database update for your changes.

In order to migrate your local database, simply run the update command:
```
dotnet ef database update
```

To reverse a migration, run the migration script for the previous migration you'd like to revert to:
```
dornet ef datbase update InitialCreate
```

Suggested reading to understand more about how the Entity Frameworks assists in the management of database changes:
https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/migrations

https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/teams