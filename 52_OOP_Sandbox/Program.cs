﻿//var internationalPizzaDay23 = new DateTime(2023, 2, 9);

//Console.WriteLine(internationalPizzaDay23.ToString());
//Console.WriteLine(internationalPizzaDay23.DayOfWeek);

//var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

//Console.WriteLine();
//Console.WriteLine($"year is {internationalPizzaDay24.Year}");
//Console.WriteLine($"month is {internationalPizzaDay24.Month}");
//Console.WriteLine($"day is {internationalPizzaDay24.Day}");
//Console.WriteLine($"day of the week is {internationalPizzaDay24.DayOfWeek}");
//Console.WriteLine($"day of the year is {internationalPizzaDay24.DayOfYear}");

var rectangle1 = new Rectangle();

Console.WriteLine($"Width is {rectangle1.Width}");
Console.WriteLine($"height is {rectangle1.Height}");

rectangle1.Width = 10;

Console.ReadKey();

class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}
