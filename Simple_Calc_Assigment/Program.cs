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

if (funcSelect == "A")
{
    result = Add(num1, num2);
}
else if (funcSelect == "S")
{
    result = Substract(num1, num2);
}
else if (funcSelect == "M")
{
    result = Multiply(num1, num2);
}
else
{
    result = "Invalid option";
}

string Multiply(int num1, int num2)
{
    return (num1 * num2).ToString();
}

string Substract(int num1, int num2)
{
    return (num1 - num2).ToString();
}

string Add(int num1, int num2)
{
    return (num1 + num2).ToString();
}
