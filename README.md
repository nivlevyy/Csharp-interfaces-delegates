<h1 align="center">
  <a><img src="https://github.com/nivlevyy/Csharp-interfaces-delegates/blob/main/image/DALL%C2%B7E-2024-10-28-14.46.png" width="300"></a>
  <br>
# Hierarchical Menu Management System

A comprehensive console-based hierarchical menu management system developed in C#. This project showcases the use of object-oriented programming concepts such as interfaces, polymorphism, and delegation. Users can navigate a structured, multi-level menu to execute various commands and return to previous menus.

## Features

- **Multi-Level Menu System**: Navigate through a structured menu with sub-menus and actionable items.
- **Interface-Based Actions**: Implements actions via interfaces, providing flexibility and adherence to OOP principles.
- **Delegation and Modularity**: Separates concerns through classes, promoting readable and maintainable code.
- **Error Handling**: Validates user inputs and displays error messages to guide users.
- **Configuration Support**: The `App.config` file provides configuration settings, ensuring customizability.

## Project Structure

The repository includes the following key files and classes:

- **MainMenu.cs**: Manages the main menu interface, displaying menu items and executing user-selected actions.
- **Menu.cs**: Implements the core menu structure and logic, including sub-menu handling, navigation, and display.
- **MenuItem.cs**: Abstract base class for menu items, enforcing the `Execute` method.
- **ActionItem.cs**: Represents actionable menu items and triggers specific actions via interfaces.
- **IMenuAction.cs**: Interface defining the `Execute` method, ensuring consistency across different actions.
- **EventMenu.cs**: Defines event-driven menu options, allowing actions to trigger events when selected.
- **InterfacesMenu.cs**: Implements various interfaces, providing different actions that can be added to the menu.
- **Methods.cs**: Contains supporting methods used across the menu system.
- **Program.cs**: Entry point for the application, initializing the menu structure and launching the program.
- **Actions.cs**: Defines additional actions that can be executed by the menu items.


## Getting Started

1. **Clone the repository**:
   ```bash
   git clone `https://github.com/nivlevyy/Csharp-interfaces-delegates.git`
