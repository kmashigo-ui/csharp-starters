# csharp-starters

A single GitHub repo for starting C# projects.

Add a new project:

```powershell
dotnet new console -o src/ProjectName -f net9.0
dotnet sln csharp-starters.sln add src/ProjectName/ProjectName.csproj
```

Run a project:

```powershell
dotnet run --project src/ProjectName
```
