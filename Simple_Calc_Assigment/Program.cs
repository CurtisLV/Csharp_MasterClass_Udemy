Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");

string userInputFirst = Console.ReadLine();
int num1 = int.Parse(userInputFirst);

Console.WriteLine("Input the second number: ");
string userInputSecond = Console.ReadLine();
int num2 = int.Parse(userInputSecond);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubstract");
Console.WriteLine("[M]ultiply");

string funcSelect = Console.ReadLine().ToUpper();

string result = "";

switch (funcSelect)
{
    case "A":
        break;
    case "S":
        break;
    case "M":
        break;
    default:
        break;
}

if (funcSelect == "A")
{
    result = Printer(num1, num2, num1 + num2, "+");
}
else if (funcSelect == "S")
{
    result = Printer(num1, num2, num1 - num2, "-");
}
else if (funcSelect == "M")
{
    result = Printer(num1, num2, num1 * num2, "*");
}
else
{
    result = "Invalid option";
}

Console.WriteLine(result);

Console.WriteLine("Press any key to close");
Console.ReadKey();

string Printer(int num1, int num2, int result, string @operator)
{
    return $"{num1} {@operator} {num2} = {result}";
}
