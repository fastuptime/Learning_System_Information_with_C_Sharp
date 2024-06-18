# Learning System Information with C#

![image](https://github.com/fastuptime/Learning_System_Information_with_C_Sharp/assets/63351166/a7860f43-aea9-447a-9124-6276bace99b3)


🚀 **Welcome to Learning System Information with C#!** 🚀

This project demonstrates how to retrieve and display system information using C#. By leveraging various system management libraries and APIs, this application can gather details about the operating system, processor, memory, disk drives, and network adapters. 

## 📋 Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Code Overview](#code-overview)
- [Contributing](#contributing)
- [License](#license)

## ✨ Features

- **Operating System Information**: Retrieve details such as OS name, version, and manufacturer.
- **Processor Information**: Get the processor name, manufacturer, and description.
- **Memory Information**: Display memory capacity and speed.
- **Disk Drive Information**: Show disk model, interface type, and media type.
- **Network Adapter Information**: List all network adapters with their name, description, status, and speed.

## 🛠️ Installation

1. **Clone the Repository**:
    ```sh
    git clone https://github.com/fastuptime/Learning_System_Information_with_C_Sharp.git
    ```
2. **Open the Project**:
    - Open the solution file (`.sln`) in Visual Studio.

3. **Restore NuGet Packages**:
    - Ensure you have the `System.Management` package installed via the NuGet Package Manager.
    - To install manually, use:
      ```sh
      Install-Package System.Management
      ```

4. **Build and Run**:
    - Build the solution and run the application.

## 🎮 Usage

1. **Start the Application**:
    - Run the application from Visual Studio.

2. **Get System Information**:
    - Click the `Get System Information` button.
    - The system information will be displayed in the rich text box.

![image](https://github.com/fastuptime/Learning_System_Information_with_C_Sharp/assets/63351166/8d0e67a1-ce16-4bf6-9412-7ed877ada31b)


## 📝 Code Overview

The core functionality is encapsulated in the `Form1` class:

- **Event Handling**: The `button1_Click` method handles the button click event to initiate the system information retrieval.
- **Information Retrieval**: The `ListSystemInfo` method compiles system information using the `GetManagementObject` helper method.
- **Management Objects**: The `GetManagementObject` method uses WMI (Windows Management Instrumentation) to query system properties.

### Example of Retrieving Processor Information
```csharp
sb.AppendLine("Processor Information:");
sb.AppendLine(GetManagementObject("Win32_Processor", "Name"));
sb.AppendLine(GetManagementObject("Win32_Processor", "Manufacturer"));
sb.AppendLine(GetManagementObject("Win32_Processor", "Description"));
```

## 🤝 Contributing

Contributions are welcome! Please fork this repository and submit pull requests.

1. **Fork the Repository**
2. **Create a Feature Branch**:
    ```sh
    git checkout -b feature-branch
    ```
3. **Commit Your Changes**:
    ```sh
    git commit -m 'Add some feature'
    ```
4. **Push to the Branch**:
    ```sh
    git push origin feature-branch
    ```
5. **Open a Pull Request**
