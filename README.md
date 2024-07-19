# Unity Design Patterns

This repository demonstrates various design patterns implemented in Unity. Each pattern is shown with practical examples to help you understand how to apply them in game development.

## Command Pattern

The Command pattern encapsulates a request as an object, allowing for parameterization of clients with different requests, queuing or logging of requests, and supporting undoable operations. Here's a detailed explanation of how it's implemented in this project.

### Components

1. **ICommand Interface**
2. **MoveCommand Class**
3. **RotateCommand Class**
4. **CommandManager Class**
5. **PlayerController Class**

### ICommand Interface

The `ICommand` interface defines the structure for all command classes. Each command must implement the `Execute` and `Undo` methods.

- **Role**: Interface
- **Function**: Provides a contract for executing and undoing commands.

### MoveCommand Class

The `MoveCommand` class implements the `ICommand` interface and encapsulates the logic for moving the player in a specific direction. It takes the player's transform, the direction to move, and the distance as parameters.

- **Role**: Command
- **Function**: Moves the player in a specified direction by a specified distance.

### RotateCommand Class

The `RotateCommand` class implements the `ICommand` interface and encapsulates the logic for rotating the player by a specified angle. It takes the player's transform and the angle to rotate as parameters.

- **Role**: Command
- **Function**: Rotates the player by a specified angle.

### CommandManager Class

The `CommandManager` class manages the execution and undoing of commands. It maintains a history of executed commands to support undo functionality.

- **Role**: Invoker
- **Function**: Executes and undoes commands, maintaining a history of executed commands.

### PlayerController Class

The `PlayerController` class handles user input and creates commands based on that input. It then passes these commands to the `CommandManager` for execution.

- **Role**: Client
- **Function**: Handles user input, creates command instances, and sends them to the `CommandManager` for execution.

### Usage

1. **PlayerController**: This script should be attached to the player GameObject. It handles input and uses the `CommandManager` to execute commands.
2. **CommandManager**: Manages the execution and undoing of commands.
3. **MoveCommand** and **RotateCommand**: Encapsulate the actions of moving and rotating the player, respectively.

With these scripts in place, you can control the player using the following keys:
- `W`, `A`, `S`, `D`: Move the player.
- `Q`, `E`: Rotate the player.
- `Z`: Undo the last command.

---

