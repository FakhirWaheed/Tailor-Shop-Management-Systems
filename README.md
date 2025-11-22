# Tailor Shop Management System

**Tailor Shop Management System** — a desktop (Windows Forms / WinForms) application written in C# to manage customer measurements, orders, billing, and tailoring workflow.

## Features
- Customer CRUD (Add / Edit / Delete)
- Measurement records for each customer
- Order tracking (stitching, pending, delivered)
- Simple billing and invoice export
- Search customers & orders
- Local database (SQLite / SQL Server) integration (configure in `App.config`)

## How to run
1. Open `Tailor Shop Management Systems.sln` in Visual Studio 2019/2022.
2. Restore NuGet packages (Build → Restore NuGet Packages).
3. Set the correct connection string in `App.config` / program settings:
```xml
<connectionStrings>
  <add name="OurConnstring" connectionString="Data Source=YOUR-SERVER;Initial Catalog=TailorDB;Integrated Security=True;" />
</connectionStrings>
