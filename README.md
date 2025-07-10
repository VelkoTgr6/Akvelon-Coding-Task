# Akvelon FizzBuzz Coding Task

A .NET 8 console application that processes a string input and applies FizzBuzz logic to every 3rd, 5th, and 15th alphanumeric word. The application outputs the transformed string and the count of replacements.

## Features
- Replaces every 3rd word with "Fizz", every 5th with "Buzz", and every 15th with "FizzBuzz".
- Input validation: accepts strings between 7 and 100 characters.
- Clear error messages for invalid input.
- Modular, testable architecture with service and detector layers.

## Requirements
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Getting Started

### Build and Run
1. Clone the repository:
   ```sh
   git clone https://github.com/VelkoTgr6/Akvelon-Coding-Task

   cd AkvelonCoddingTask
   ```
2. Build the solution:
   ```sh
   dotnet build
   ```
3. Run the application:
   ```sh
   dotnet run --project AkvelonCoddingTask/AkvelonCoddingTask.csproj
   ```
4. Enter your input string when prompted.

### Example
```
Enter Input:
one two three four five six seven eight nine ten eleven
output string:
one two Fizz four Buzz Fizz seven eight Fizz Buzz eleven

count: 4
```

## Testing
Unit tests are provided in the `Tests` project. To run tests:
```sh
dotnet test
```

## Project Structure
- `AkvelonCoddingTask/` - Main application code
- `Tests/` - Unit tests

## Code Style
- Follows Google C# Style Guide
- Includes XML documentation for public members

## License
This project is for demonstration and educational purposes.
