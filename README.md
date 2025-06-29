# 🌿 SproutBase

SproutBase is a responsive CRUD application built with Blazor, ASP.NET Core Web API, Entity Framework Core, and SQL Server (LocalDB). It allows users to track their plants, including the name, species, last watered date, and custom tags.

## ✨ Features

- Add, edit, and delete plants
- Search and filter by name or tag
- Responsive layout for all screen sizes
- Autocomplete tag suggestions when typing
- Confirmation dialog before deleting a plant
- Highlight plants overdue for watering (red if >7 days, yellow if watered today)
- Watering recommendations based on current local conditions

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
    ```

2. **Restore and build**

    ```bash
    dotnet restore
    dotnet build
    ```

3. **Add initial migration**

    ```bash
    dotnet ef migrations add InitialCreate --project PlantTrackerApp.Server
    ```

4. **Apply migrations & create database**

    ```bash
    dotnet ef database update --project PlantTrackerApp.Server
    ```

5. **Run the app**

    ```bash
    dotnet run --project PlantTrackerApp.Server
    ```

6. **Open your browser**

    By default, the app runs at `http://localhost:5180` or `https://localhost:7121` (or whichever port is listed in your terminal). Open your browser at the appropriate URL to access SproutBase.

## Acknowledgements

This project was built as part of a technical evaluation. Thank you to [Frontpoint](https://www.frontpointsecurity.com/) for the opportunity to showcase my skills in such a fun and engaging way.

