# 📅 EventPlanningApp

<div align="center">

![.NET Framework](https://img.shields.io/badge/.NET-4.8-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-Windows%20Forms-239120?style=for-the-badge&logo=c-sharp)
![Windows](https://img.shields.io/badge/Windows-Desktop%20App-0078D6?style=for-the-badge&logo=windows)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-5C2D91?style=for-the-badge&logo=visual-studio)

**EventPlanningApp** is a Windows Forms desktop application for event planning, RSVP tracking, task and budget management, and feedback collection – built on .NET Framework 4.8.

</div>

---

## ✨ Key Features

- 🔐 **User authentication** – Sign‑up, login, and confirmation code flow  
- 📅 **Event management** – Create, edit, and manage events  
- ✅ **RSVP tracking** – Track attendees and generate reports  
- 💰 **Budget & task management** – Per‑event budget tracking and task lists  
- 📁 **Templates** – Reusable event templates for faster creation  
- 🔔 **Notifications** – In‑app alerts and reminders  
- 💬 **Feedback collection** – User feedback forms  

---

## 🛠 Prerequisites

- Windows 10 or later  
- Visual Studio 2022  
- .NET Framework 4.8 Developer Pack  

---

## 🚀 Getting Started (Build & Run)

1. **Clone the repository**
   ```bash
   git clone https://github.com/Edwinuniv/EventPlanningApp.git
Open the solution in Visual Studio 2022 (double‑click the .sln file).

Restore NuGet packages if prompted (right‑click solution → Restore NuGet Packages).

Set the startup project – usually the main Windows Forms project.

Ensure the target framework is .NET Framework 4.8 (Project → Properties → Application).

Build the solution (Ctrl + Shift + B or Build → Build Solution).

Run the application (F5 or Debug → Start Debugging).

📁 Project Structure (Key Files)
File	Purpose
Program.cs	Application entry point
MainPage.cs	Main application UI
LoginForm.cs, SignUp_page.cs, Confirmcode_page.cs	Authentication flows
EventForm.cs, Event.cs	Event creation and model
RSVPtrackingForm.cs, RsvpTracking.cs	RSVP handling and reports
Tasks.cs, TaskForm.cs	Task management
Budget.cs, BudgetForm.cs	Budget management
Template.cs, TemplateForm.cs	Event templates
Reports.cs, ReportsForm.cs	Reporting system
FeedbackForm.cs, FeedbackForm.Designer.cs	Feedback collection UI
User.cs	User data model
📐 Coding Standards & Guidelines
This repository uses an .editorconfig and CONTRIBUTING.md to define formatting rules. Follow them strictly for indentation, naming, and other style requirements.

Keep changes small and focused.

Follow the Single Responsibility Principle for new classes and forms.

🤝 Contributing
Open an issue for significant changes or bug reports.

Create feature branches: feature/<short-description>
Bugfix branches: bugfix/<short-description>

Submit pull requests against the main branch with a clear description and testing notes.

Ensure the code builds and runs locally before submitting a PR.

🧪 Troubleshooting
Issue	Solution
Build fails due to missing references	Confirm .NET Framework 4.8 is installed and NuGet packages are restored
Runtime errors	Run under the debugger to inspect exceptions and stack traces
📄 License
No license file is currently included. Contact the repository owner for licensing details.

📞 Maintainers / Contact
Repository: github.com/Edwinuniv/EventPlanningApp

Questions or access: Open an issue in the repository

📝 Notes
This README is a starting point. As the project evolves, consider adding:

Architecture overview

Database schema (if any)

Screenshots or demo GIFs

CI/CD pipeline details

<div align="center">
Built with C# and Windows Forms

</div> ```
