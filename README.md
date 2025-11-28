# Cash Register

This project is a small Windows Forms point‑of‑sale (POS) application written in C# for .NET Framework 4.7.2. It manages product categories and items, builds receipts, stores receipts in a database, and updates sold quantities. 

Features
- Browse categories and items.
- Add items with quantities to the current receipt.
- Generate and persist receipts
- Update sold counts for items.
- Simple warning log for restricted sales

Prerequisites
- Visual Studio 2022
- .NET Framework 4.7.2
- A SQL database accessible by the included `Database` helper (adjust connection string in your project)

Build & run
1. Open the solution in Visual Studio 2022.
2. Ensure the project targets __.NET Framework 4.7.2__ (Project Properties).
3. Configure your database connection in the `Database` class or in `app.config`.
4. Build and run (F5).
