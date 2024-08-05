# Advanced C#

## Table of Contents
1. [Delegates](#delegates)
2. [Built-in Delegates](#built-in-delegates)
3. [Anonymous Methods and Lambda Expressions](#anonymous-methods-and-lambda-expressions)
4. [New Delegate Features in C# 10.0](#new-delegate-features-in-c-100)
5. [Functions Returning Functions](#functions-returning-functions)

## Delegates

Delegates in C# are type-safe function pointers. They allow methods to be passed as parameters, enabling flexible and extensible code designs.

### Basic Delegate Syntax

```csharp
public delegate int MathOperation(int x, int y);

class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Multiply(int a, int b) => a * b;
}

// Usage
MathOperation operation = Calculator.Add;
int result = operation(5, 3); // result = 8
```

## Generic Delegate Example
```csharp
public delegate T GenericOperation<T>(T a, T b);

class GenericCalculator
{
    public static T Add<T>(T a, T b) where T : struct, IAdditionOperators<T, T, T>
    {
        return a + b;
    }
}

// Usage
GenericOperation<double> doubleOperation = GenericCalculator.Add;
double result = doubleOperation(5.5, 3.2); // result = 8.7
```

## Multicast Delegate
```csharp
public delegate void Logger(string message);

class LogManager
{
    public static void ConsoleLog(string message) => Console.WriteLine($"Console: {message}");
    public static void FileLog(string message) => File.AppendAllText("log.txt", $"File: {message}\n");
}

// Usage
Logger log = LogManager.ConsoleLog;
log += LogManager.FileLog;
log("This message will be logged to both console and file");
```

## Built-in Delegates
C# provides built-in delegate types for common scenarios: Predicate, Func, and Action.
Predicate

```csharp
Predicate<T> represents a method that takes one input parameter and returns a boolean.
```

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Predicate<int> isEven = num => num % 2 == 0;
List<int> evenNumbers = numbers.FindAll(isEven);
```

## Func
Func<T, TResult> represents a method that takes one input parameter and returns a value.

```csharp
Func<int, int, int> multiply = (x, y) => x * y;
int result = multiply(5, 3); // result = 15
```

## Action
Action<T> represents a method that takes one input parameter and does not return a value.

```csharp
Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
greet("Alice"); // Outputs: Hello, Alice!
```

## Anonymous Methods and Lambda Expressions
Anonymous methods and lambda expressions provide concise ways to define inline methods.
```csharp
Func<int, int, int> add = delegate(int x, int y) { return x + y; };
int result = add(5, 3); // result = 8
```

## Lambda Expression
```csharp
Func<int, int, int> multiply = (x, y) => x * y;
int result = multiply(5, 3); // result = 15
```

## New Delegate Features in C# 10.0
C# 10.0 introduced improvements to delegate creation and invocation.

## Delegate Creation with Method Group
```csharp
// Pre-C# 10.0
Func<int, int, int> oldAdd = (x, y) => Calculator.Add(x, y);

// C# 10.0 and later
Func<int, int, int> newAdd = Calculator.Add;
```
## Functions Returning Functions
Functions that return functions are a powerful feature of functional programming, which C# supports through delegates.

```csharp
Func<int, Func<int, int>> createMultiplier = x => y => x * y;

var doubler = createMultiplier(2);
int result = doubler(5); // result = 10

var tripler = createMultiplier(3);
result = tripler(5); // result = 15
```



