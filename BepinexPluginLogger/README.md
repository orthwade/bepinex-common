# BepinexPluginLogger Project

## Overview
The BepinexPluginLogger project provides a centralized logging mechanism for the Tools Melee Recharge plugin. It allows developers to easily log information, warnings, and errors, while also providing configuration options to enable or disable logging.

## Features
- Centralized logging for the Tools Melee Recharge plugin.
- Configurable logging options through BepInEx.
- Supports logging of information, warnings, and errors.

## Setup Instructions
1. Clone the repository:
   ```
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```
   cd BepinexPluginLogger
   ```
3. Open the solution in your preferred C# development environment.

## Usage
To use the `BepinexPluginLogger`, initialize it in your plugin's entry point with the following code:

```csharp
BepinexPluginLogger.Init(config, "YourPluginName");
```

You can then log messages using:

```csharp
BepinexPluginLogger.LogInfo("This is an info message.");
BepinexPluginLogger.LogWarning("This is a warning message.");
BepinexPluginLogger.LogError("This is an error message.");
```

## Configuration
Logging can be enabled or disabled through the configuration file. By default, logging is enabled. You can change this setting in the `00 - General` section of your configuration.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.