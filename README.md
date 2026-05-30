Here's the improved `README.md` file, incorporating the new content while maintaining the existing structure and information:


# EventPlanningApp

EventPlanningApp is a Windows Forms application for event planning and RSVP tracking, built on .NET Framework 4.8. The project contains forms for user authentication, event creation and management, task and budget tracking, notifications, reports, templates, and feedback handling.

## Key Features
- User sign-up, login, and confirmation code flow
- Create, edit, and manage events
- RSVP tracking and reports
- Task and budget management per event
- Templates for event creation
- Notifications and feedback collection

## Prerequisites
- Windows 10 or later
- Visual Studio 2022
- .NET Framework 4.8 Developer Pack

## Getting Started (Build & Run)
1. Clone the repository:

   git clone https://github.com/Edwinuniv/EventPlanningApp.git

2. Open the solution in Visual Studio 2022 (`.sln` file).
3. Restore NuGet packages if prompted (__Restore NuGet Packages__).
4. Set the startup project (usually the main Windows Forms project) and ensure the target frameworkis .NET Framework 4.8.
5. Build the solution (__Build > Build Solution__ or `Ctrl+Shift+B`).
6. Run the application (__Debug > Start Debugging__ or `F5`).

##Project Structure (Important Files)
- `Program.cs` — application entry point.
- `MainPage.cs` — main application UI.
- `LoginForm.cs`, `SignUp_page.cs`, `Confirmcode_page.cs` — authentication flows.
- `EventForm.cs`, `Event.cs` — event creation and model.
- `RSVPtrackingForm.cs`, `RsvpTracking.cs` — RSVP handling.
- `Tasks.cs`, `TaskForm.cs` — task management.
- `Budget.cs`, `BudgetForm.cs` — budget management.
- `Template.cs`, `TemplateForm.cs` — templates.
- `Reports.cs`, `ReportsForm.cs` — reporting.
- `FeedbackForm.cs`, `FeedbackForm.Designer.cs` — feedback collection UI.
- `User.cs` — user model.

## Coding Standards and Guidelines
- This repository uses an `.editorconfig` and `CONTRIBUTING.md` to define formatting and contribution rules. Follow those files strictly for indentation, naming, and other style requirements.
- Keep changes small and focused; follow the Single Responsibility Principle for new classes and forms.

## Contributing
- Open an issue for significant changes or bug reports.
- Create feature branches named `feature/<short-description>` or bugfix branches `bugfix/<short-description>`.
- Submit pull requests against `main` with a clear description and testing notes.
- Ensure code builds and runs locally before submitting a PR.

## Troubleshooting
- If the build fails due to missing references, confirm that `.NET Framework 4.8` is installed and NuGet packages are restored.
- For runtime issues, run under the debugger to inspect exceptions and stack traces.

## License
- No license file is included in the repository. Add a `LICENSE` file or contact the repository owner for licensing details.

## Maintainers / Contact
- Repository: [EventPlanningApp GitHub](https://github.com/Edwinuniv/EventPlanningApp)
- For questions or access, open an issue in the repository.

## Notes
- This README is intended as a starting point. Add additional sections (architecture, database, CI/CD) as the project evolves.


### Changes Made:
1. Added headings for clarity and organization.
2. Ensured consistent formatting throughout the document.
3. Used bullet points and sections to enhance readability.
4. Included a link to the GitHub repository in the Maintainers / Contact section for easy access.
