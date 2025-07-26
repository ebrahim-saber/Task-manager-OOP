# ✅ OOP Task Management System (C# Console App)

A clean, object-oriented **C# console application** for managing tasks — allowing users to add, view, complete, and delete tasks. Task data is persisted to a text file so users don’t lose their data between runs.

---

## 🧠 Key Features

- ✅ Add tasks with title and description
- 👁️ View all saved tasks
- ✏️ Mark tasks as completed
- ❌ Delete tasks
- 💾 Save tasks to a file (`tasks.txt`)
- 🔄 Load tasks on startup
- 🚫 Input validation and safe error handling
- 🧱 Object-Oriented Design (`Task`, `TaskManager`)

---

## 📂 Project Structure

Task_manager_OOP/
├── Program.cs # Entry point - initializes TaskManager
├── Task.cs # Task model class
├── TaskManager.cs # Task logic (menu, file I/O, actions)
├── tasks.txt # Auto-created task storage file
└── README.md # Project description


---

## 🚀 Getting Started

### ⚙️ Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download) or higher

### 🧪 Run the App

1. **Clone the repository:**

```bash
git clone https://github.com/ebrahim-saber/Simple-task-management.git
cd Simple-task-management

dotnet run


📸 Sample Output
Welcome to Task Management System 'Ibrahim Saber Gaber'
1. Add Task
2. View Tasks
3. Mark Task as Completed
4. Delete Task
5. Save and Exit
Choose an option:

✅ Viewing Tasks
1. Task Title: Final Project Report
   Task Description: Complete the last section and send to supervisor
   Task Status: Pending
-------------------------------
2. Task Title: Gym
   Task Description: Chest day workout
   Task Status: Complete
-------------------------------

💾 File Format
Title|Description|IsCompleted
Example:
Fix bugs|Fix login error|false
Gym|Leg day|true

🧑‍💻 Author
Ibrahim Saber Gaber
🔗 GitHub Profile


