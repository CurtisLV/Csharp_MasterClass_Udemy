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

var medicalAppointment = new MedicalAppointment("John Kaxx", new DateTime(2023, 6, 12));
var medicalAppointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);
var medicalAppointmentOneWeekFromNow = new MedicalAppointment("Margaret Smith");
var medicalAppointmentUnknownPatient = new MedicalAppointment();

// simply reschedule
medicalAppointment.Reschedule(new DateTime(2023, 7, 12));

Console.ReadKey();

class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        int defaultValueIfNonPositive = 1;
        if (width <= 0)
        {
            Console.WriteLine("Width must be a positive number.");
            Width = defaultValueIfNonPositive;
        }
        else
        {
            Width = width;
        }

        if (height <= 0)
        {
            Console.WriteLine("Height must be a positive number.");
            Height = defaultValueIfNonPositive;
        }
        else
        {
            Height = height;
        }
    }

    private int GetLengthOrDefault(int length, string name)
    {
        //
    }

    public int CalculateRectangleCircumference() => 2 * Width + 2 * Height;

    public int CalculateRectangleArea() => Width * Height;
}

// Method overloading

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine($"Appointment will take place on {medicalAppointment.GetDate()}");
    }
}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public DateTime GetDate() => _date;

    //public MedicalAppointment(string patientName)
    //    : this(patientName, 7) { }

    public MedicalAppointment(string patientName = "Unknown", int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
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

// Third assignment

class Dog
{
    private string _name;
    private string _bread;
    private int _weight;

    public Dog(string name, string bread, int weight)
    {
        _name = name;
        _bread = bread;
        _weight = weight;
    }

    public Dog(string name, int weight)
        : this(name, "mixed-breed", weight) { }

    public string Describe()
    {
        return $"This dog is named {_name}, it's a {_bread}, and it weighs {_weight} kilograms, so it's a {DescribeSize(this)} dog.";
    }

    public string DescribeSize(Dog dog)
    {
        if (dog._weight < 5)
        {
            return "tiny";
        }
        else if (dog._weight >= 5 && dog._weight < 30)
        {
            return "medium";
        }
        else
        {
            return "large";
        }
    }
}
