# Frontend README

This README provides instructions on setting up and using the frontend application developed in VB.NET using Visual Studio.

## Prerequisites
- Visual Studio with VB.NET support installed.

## Setup Instructions
1. Clone or download the repository containing the VB.NET project.
2. Open the project in Visual Studio.
3. Build the solution to restore dependencies and compile the project.

## Running the Application
1. Set the startup project to the VB.NET project.
2. Press `F5` or click the "Start" button to run the application.
3. The main form (`MainForm`) of the application will appear.

## Features
- **Create New Submission**: Click the "Create New Submission" button to open a form where new submissions can be entered and submitted to the backend.
- **View Submissions**: Click on the "View Submissions" button to navigate through existing submissions stored in the backend.
- **Edit Submissions**: Each submission in the "View Submissions" form can be edited by clicking the "Edit" button, which opens a form with pre-filled details that can be modified and re-submitted.
- **Delete Submissions**: Submissions can be deleted by clicking the "Delete" button in the "View Submissions" form.
- **Keyboard Shortcuts**: Supports keyboard shortcuts (`Ctrl + N` for creating a new submission, `Ctrl + V` for viewing submissions and others mentioned in the application).

## Notes
- Ensure the backend server is running and accessible before using features that interact with it (such as viewing, editing, and deleting submissions).
