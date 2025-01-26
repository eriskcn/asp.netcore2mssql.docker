**Warning: DMM remember to migrate before running project**

```bash
dotnet ef migrations add <InitialCreate>
dotnet ef database update
```

**Warning: DMM remember to register `ApplicationDbContext` in `Program.cs`**

```csharp
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 
```

## ConnectionString for MSSQLServer from Docker

```json lines   
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1433;Database=test;User Id=sa;Password=TLU@42742hoai;Integrated Security=False;Encrypt=False;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

```