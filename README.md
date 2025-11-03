# BlogApp_MVC

A blog platform built with **.NET 9 (MVC)**, **Entity Framework Core**, and **SQLite**. This project features post management, user authentication with .NET Identity, comments, and tagging.

![.NET Version](https://img.shields.io/badge/.NET-9.0-blueviolet)
![Database](https://img.shields.io/badge/Database-SQLite-003B57)
![License](https://img.shields.io/badge/license-MIT-blue.svg) 

* **Post Management:** Full CRUD operations for blog posts.
* **Authentication:** User registration and login using **.NET Core Identity**.
* **Admin Panel:** A dedicated area for managing users and posts.
* **Dynamic Content:** Support for **Comments** and **Tags** on posts.

## 🛠️ Tech Stack

* .NET 9 (ASP.NET Core MVC)
* Entity Framework Core
* .NET Core Identity
* SQLite Database
* Bootstrap 5 (Frontend)

## 🚀 Quick Start

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/aliemirkoca/BlogApp_MVC.git](https://github.com/aliemirkoca/BlogApp_MVC.git)
    cd BlogApp_MVC
    ```

2.  **Restore dependencies:**
    ```bash
    dotnet restore
    ```

3.  **Apply database migrations:**
    (This will create the `blog.db` file in the main project folder)
    ```bash
    dotnet ef database update
    ```

4.  **Run the application:**
    ```bash
    dotnet run
    ```
