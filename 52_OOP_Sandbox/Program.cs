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

var rectangle1 = new Rectangle(5, 10);

Console.WriteLine($"Width is {rectangle1.Width}");
Console.WriteLine($"height is {rectangle1.Height}");
Console.WriteLine($"Area is {rectangle1.CalculateRectangleArea()}");
Console.WriteLine($"Circumference is {rectangle1.CalculateRectangleCircumference()}");

Console.WriteLine();

var rectangle2 = new Rectangle(55, 12);

Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"height is {rectangle2.Height}");
Console.WriteLine($"Area is {rectangle2.CalculateRectangleArea()}");
Console.WriteLine($"Circumference is {rectangle2.CalculateRectangleCircumference()}");

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

    public int CalculateRectangleCircumference(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.Height;
    }

    public int CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}

// Method overloading

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public MedicalAppointment(string patientName)
        : this(patientName, 7) { }

    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedule(DateTime date)
    {
        _date = date;
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
    }
}

// First coding assignment
class HotelBooking
{
    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);
    }
}

// Second coding assignment
class Triangle
{
    private int Base;
    private int Height;

    public Triangle(int @base, int height)
    {
        Base = @base;
        Height = height;
    }

    public int CalculateArea()
    {
        return ((Base * Height) / 2);
    }

    public string AsString()
    {
        return $"Base is {Base}, height is {Height}";
    }
}
