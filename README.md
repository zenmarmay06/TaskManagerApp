🚀 Task Manager App

A desktop task and time management application built with C#, Windows Forms, and SQLite.
Designed to help users efficiently manage tasks with role-based access, priority handling, and overdue tracking.

✨ Features

🔐 User Authentication & Roles
Admin / User role system
Secure login structure
✅ Task Management (CRUD)
Create, update, delete, and list tasks
Assign tasks to users
⏰ Due Date & Overdue Detection
Automatic overdue status tracking
Visual highlighting for overdue tasks
🎯 Priority System
Low / Medium / High priority levels
Easy filtering and selection
🎨 Clean & User-Friendly UI
Simple and modern Windows Forms design
DataGridView-based task visualization


🏗️ Architecture

The project follows a layered architecture:

TaskManager
│
├── TaskManager.UI        → Windows Forms (Presentation Layer)
├── TaskManager.Business  → Business Logic
├── TaskManager.Data      → Data Access (SQLite)
├── TaskManager.Core      → Models / Entities
🛠️ Technologies Used
C#
.NET (Windows Forms)
SQLite
ADO.NET

📸 Screenshots

<img width="1078" height="617" alt="image" src="https://github.com/user-attachments/assets/8458002e-e408-42a7-bd1a-d82c0c73ee73" />

<img width="1049" height="601" alt="image" src="https://github.com/user-attachments/assets/f6242324-bb69-4162-bce5-75f42daf73c5" />

<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/cfe7bfa0-7ae2-488a-b43d-24913ab836b1" />






⚙️ Installation

Option 1 – Run directly
Download the project
Go to:
bin/Release/
Run:
TaskManager.exe
Option 2 – Build from source
Open solution in Visual Studio
Restore dependencies
Build the solution
Run the project
🗄️ Database
SQLite is used as a local database
Database file is included in the project
Schema updates can be applied manually if needed

Example:

ALTER TABLE Tasks ADD COLUMN Priority TEXT;


🎯 Project Purpose

This project was developed to:

Practice desktop application development
Apply layered architecture principles
Improve database integration skills
Build a portfolio-ready real-world application
🚧 Possible Improvements
🔍 Task filtering & search
📊 Dashboard with statistics
🌙 Dark mode support
🌐 Migration to web (ASP.NET Core)
🔔 Notification system
👤 Author

Developed by Nazan Deniz
⭐ Show Your Support

If you like this project, consider giving it a ⭐ on GitHub!
