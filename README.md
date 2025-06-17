# 🌿 SproutBase

SproutBase is a responsive CRUD application built with Blazor, ASP.NET Core Web API, Entity Framework Core, and SQL Server (LocalDB). It allows users to track their plants, including the name, species, last watered date, and custom tags.

## ✨ Features

- Add, edit, and delete plants
- Search and filter by name or tag
- Responsive layout for all screen sizes

## 🧱 Tech Stack

- **Frontend:** Blazor WebAssembly
- **Backend:** ASP.NET Core Web API
- **ORM:** Entity Framework Core
- **Database:** LocalDB (SQL Server Express)
- **Styling:** Custom CSS (no external frameworks)

## 🚀 Getting Started

### Prerequisites

- .NET 8
- Visual Studio 2022+ (with ASP.NET and web development workload)
- SQL Server Express (LocalDB)

### Setup

1. **Clone the repository**

   ```bash
   git clone https://github.com/cluzier/SproutBase.git
   cd SproutBase

2. **Restore and build**

    ```bash
    dotnet restore
    dotnet build

3. **Apply migrations & create database**

    ```bash
    dotnet ef database update

4. **Run the app**

    ```bash
    dotnet run --project Server

Open your browser at https://localhost:7121 (or whichever port is listed).

## Acknowledgements

This project was built as part of a technical evaluation. Thank you to [Frontpoint](https://www.frontpointsecurity.com/) for the opportunity to showcase my skills in such a fun and engaging way.


