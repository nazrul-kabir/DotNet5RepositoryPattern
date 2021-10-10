# Repository pattern with .NET 5

Dotnet repository pattern template with unit of work. This is the basic setup for the repository pattern to work with and to understand how to implement.

The *repository pattern* is a design pattern that isolates data access behind interface abstractions. Connecting to the database and manipulating data storage objects is performed through methods provided by the interface's implementation. Consequently, there's no need for calling code to deal with database concerns, such as connections, commands, and readers.

Implementation of the repository pattern with ASP.NET Core has the following benefits:

* Organization of the app is less complex with no direct interdependency between the business and data access layers.
* It's easier to reuse database access code because the code is centrally managed by one or more repositories.
* The business domain can be independently unit tested from the database layer.
* simple experimental generic repository pattern demo on .net 5.
## Usage
* You have to setup your own connection string in appsettings.json file.
* You have to run the entity framework core migration via package manager console (In Visual Studio go to Tools -> Nuget Package Manager -> Package Manager Console then start migration with 'Update-Database' command
## Tools
VS Code (https://code.visualstudio.com/download)

Visual Studio (https://visualstudio.microsoft.com/downloads)

Dotnet 5 SDK (https://dotnet.microsoft.com/download)
## Give a Star! :star:

If you like this project, learn something or you are using it in your applications, please give it a star. Thanks!