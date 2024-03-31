using DotNet8Playground.Services;

IStringService stringService = new StringService();

// Get input
Console.WriteLine("String to reverse:");
var input = Console.ReadLine() ?? string.Empty;

// Process input
var reversedInput = stringService.ReverseString(input);

// Output results
Console.WriteLine($"\n{reversedInput}");