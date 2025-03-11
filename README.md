# Expenses

## Overview
**Expenses** is a simple expense tracker built using the .NET MVC framework. It allows you to log expenses and view them visually using **Chart.js**. This project demonstrates the use of MVC architecture, data storage, and dynamic chart rendering.

---

## Features
✅ Built with .NET MVC  
✅ Integrated with **Chart.js** for visualizing expenses  
✅ Simple and clean UI for adding and tracking expenses  

---

## Installation

### 1. **Clone the Repository**
```bash
git clone https://github.com/your-username/expenses.git
cd expenses
```

### 2. Set Up the Database Connection
## Open the appsettings.json file.
## Add your database connection string under the "ConnectionStrings" section:
```
"ConnectionStrings": {
  "DefaultConnection": "Your-Database-Connection-String"
}
```

### 3. Apply Database Migrations
```bash
dotnet ef database update
```

### 4. Run the Application
## Start the application using:
```bash
dotnet run
```
