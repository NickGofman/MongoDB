# Musician Event Management System

## Description
The Musician Event Management System is a Windows Forms application built using C# that facilitates the management of musicians, events, and their associations. The application utilizes MongoDB as the backend database to store musician and event data.

## Features
- **Manage Musicians:** Users can add, update, or delete musician records.
- **Manage Events:** Users can add, update, or delete event records.
- **Associate Musicians with Events:** The application allows users to assign musicians to specific events and vice versa.
- **Prevent Conflicts:** When updating event details, the system checks for conflicts with existing events to ensure that no two events occur at the same time.

## Installation
1. **Database Setup:** Ensure MongoDB is installed and running on your system. You can download MongoDB from the official website ([mongodb.com](https://www.mongodb.com/try/download/community)).
2. **Configuration:** Open the `Form1.cs` file and replace `"your_connection_string_here"` with your MongoDB connection string.
3. **Dependencies:** Ensure all necessary dependencies are installed, including the MongoDB C# driver.
4. **Build and Run:** Build the solution in Visual Studio and run the application.

## Usage
1. **Adding/Updating/Deleting Records:** Use the respective forms to manage musician and event records.
2. **Associating Musicians with Events:** Use the event musician management form to assign musicians to specific events or remove them from events.


## Authors
Nick Gofman, Saar Yanckovich
