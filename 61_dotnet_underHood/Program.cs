// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int number = 5;
int anothNum = number;

anothNum++;

Console.WriteLine("Number is " + number);
Console.WriteLine("2nd number is " + anothNum);

var john = new Person { Name = "John", Age = 35 };
var person = john;

person.Age = 44;

Console.WriteLine("Johns age " + john.Age);
Console.WriteLine("Persons age " + person.Age);

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
