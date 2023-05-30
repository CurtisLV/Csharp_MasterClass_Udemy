var internationalPizzaDay23 = new DateTime(2023, 2, 9);

Console.WriteLine(internationalPizzaDay23.ToString());
Console.WriteLine(internationalPizzaDay23.DayOfWeek);

var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

Console.WriteLine();
Console.WriteLine($"year is {internationalPizzaDay24.Year}");
Console.WriteLine($"month is {internationalPizzaDay24.Month}");
Console.WriteLine($"day is {internationalPizzaDay24.Day}");
Console.WriteLine($"day of the week {internationalPizzaDay24.DayOfWeek}");
Console.WriteLine($"day of the year {internationalPizzaDay24.DayOfYear}");

Console.ReadKey();
