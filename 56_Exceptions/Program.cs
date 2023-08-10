﻿Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

try
{
    int number = ParseStringToInt(input);
    var result = 10 / number;

    Console.WriteLine($"10 / {number} is {result}");
}
catch (FormatException ex)
{
    Console.WriteLine(
        "Wrong format. Input string is not parsable to int." + "\nException message: " + ex.Message
    );
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(
        "Division by zero is an invalid operation." + "\nException message: " + ex.Message
    );
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
finally
{
    Console.WriteLine("Finally block is being executed!");
}

int ParseStringToInt(string input)
{
    return int.Parse(input);
}

Console.ReadKey();

// First coding exercise
//int result = DivideNumbers(4, 0);
//Console.WriteLine(result);

//static int DivideNumbers(int a, int b)
//{
//    try
//    {
//        return a / b;
//    }
//    catch
//    {
//        Console.WriteLine("Division by zero.");
//        return 0;
//    }
//    finally
//    {
//        Console.WriteLine("The DivideNumbers method ends.");
//    }
//}
