# Answers

## Q1 - .csproj

### .csproj Contents

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>

## Q1 - .csproj Properties

- **OutputType**: Defines the type of application. `Exe` means the project is an executable application.

- **TargetFramework**: Specifies the .NET version used by the project. This project uses `net9.0`.

- **ImplicitUsings**: Automatically adds common `using` statements, so we do not need to write them manually.

- **Nullable**: Enables nullable reference type checking to help detect possible null errors.


## Q2 - #region

`#region` is used to organize and group related code in the file.

It does not change how the program works or runs.


## Q3 - XML Documentation Comments

XML documentation comments use `///` before a class or method.

They describe what the code does and can be used by tools such as IntelliSense to show documentation.



## Q4. Why does C# have no true global variables, and what's the closest equivalent?

C# has no true global variables because variables must belong to a specific scope, 
such as a class or method. The closest equivalent is a static field or property inside a class,
which can be accessed from different parts of the program.
.