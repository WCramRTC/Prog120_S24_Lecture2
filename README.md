# Prog120_S24_Lecture2


Sure, here's a breakdown of each topic along with code snippets:

### Variables
Variables are containers for storing data values. In most programming languages, variables have a specific data type, which determines the type of data that can be stored in the variable.

### String
A string is a data type used to represent text rather than numerical data. It consists of a sequence of characters, which can include letters, numbers, symbols, and whitespace.

### Type
In programming, a type defines a set of values and the operations that can be performed on those values. Types can be primitive (such as integers, floating-point numbers, and characters) or complex (such as arrays, classes, and structures).

### Declare
To declare a variable means to specify its name and type so that the compiler or interpreter knows how to allocate memory for it. Declaring a variable does not necessarily assign it a value.

### Initialize
Initializing a variable means assigning it an initial value when it is declared. This value can be specified explicitly or can be the default value for its data type.

### Assign a Value
Assigning a value to a variable means storing a specific data value in the variable. This can be done when the variable is declared or at any point later in the program.

### Reassign a Value
Reassigning a value to a variable means changing the data value stored in the variable after it has already been assigned a value.

Here are some code snippets to illustrate these concepts in C#:

```csharp
// Declare a variable
int num;

// Declare and initialize a variable
double pi = 3.14;

// Assign a value to a variable
num = 10;

// Reassign a value to the variable
num = 20;

// Declare and initialize a string variable
string message = "Hello, world!";

// Output the value of the string variable
Console.WriteLine(message);


```

---
### Console.ReadLine()
`Console.ReadLine()` is a method in the .NET Framework's `Console` class that reads a line of characters from the standard input stream (`stdin`). It reads characters from the current position of the input stream up to and including the next newline character (`\n`). The newline character is not included in the returned string.

### Usage
- **Reading Input**: It's commonly used to read input from the user in console-based applications. The input can be any sequence of characters until the user presses the Enter key.
  
- **Handling User Input**: After calling `Console.ReadLine()`, the program typically assigns the returned string to a variable for further processing or validation.
  
- **Pausing Execution**: It's often used to pause the execution of a console application, allowing the user to view output or respond to prompts before continuing.

### Example
```csharp
// Prompt the user for input
Console.WriteLine("Enter your name:");

// Read a line of input from the user
string name = Console.ReadLine();

// Greet the user
Console.WriteLine($"Hello, {name}!");

// Wait for user input before exiting
Console.ReadLine();
```

In this example:
- The program prompts the user to enter their name.
- `Console.ReadLine()` reads the input from the user and stores it in the `name` variable.
- The program then greets the user using the provided name.
- Finally, it waits for the user to press Enter before exiting, allowing them to review the output.