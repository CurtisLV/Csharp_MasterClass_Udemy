//var internationalPizzaDay23 = new DateTime(2023, 2, 9);

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
Console.WriteLine($"height is {rectangle1.GetHeight()}");
Console.WriteLine($"Area is {rectangle1.CalculateRectangleArea()}");
Console.WriteLine($"Circumference is {rectangle1.CalculateRectangleCircumference()}");

Console.WriteLine();

var rectangle2 = new Rectangle(55, 12);

Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"height is {rectangle2.GetHeight()}");
Console.WriteLine($"Area is {rectangle2.CalculateRectangleArea()}");
Console.WriteLine($"Circumference is {rectangle2.CalculateRectangleCircumference()}");

var medicalAppointment = new MedicalAppointment("John Kaxx", new DateTime(2023, 6, 12));
var medicalAppointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);
var medicalAppointmentOneWeekFromNow = new MedicalAppointment("Margaret Smith");
var medicalAppointmentUnknownPatient = new MedicalAppointment();

// simply reschedule
medicalAppointment.Reschedule(new DateTime(2023, 7, 12));

// Person class - object initializers
//var person = new Person("John", 1981);

var person = new Person { Name = "John", YearOfBirth = 1981 };

Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
Console.WriteLine($"1 - 2 is {Calculator.Substract(1, 2)}");
Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");

Console.ReadKey();

static class Calculator
{
    public static int Add(int a, int b) => a + b;

    public static int Substract(int a, int b) => a - b;

    public static int Multiply(int a, int b) => a * b;
}

class Rectangle
{
    const int NumberOfSides = 4; // value must be assigned at declaration - things with a const value known at a compilation time
    readonly int NumberOfSidesReadOnly; // value can be not assigned at declaration - when we want a field never to change after it hsa been set in the constructor

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;
    }

    public int Width { get; private set; }

    private int _height;

    public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
    }

    public int CalculateRectangleCircumference() => 2 * Width + 2 * _height;

    public int CalculateRectangleArea() => Width * _height;

    public string Description => $"A rectangle with width {Width} and height {_height}";
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

class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; init; } // init so we can initialize value but then it goes private - no setter

    //public Person(string name, int yearOfBirth)
    //{
    //    Name = name;
    //    YearOfBirth = yearOfBirth;
    //}
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

// Fourth assignment

public class Order
{
    public string Item { get; }

    private DateTime _date;

    public DateTime Date
    {
        get { return _date; }
        set
        {
            if (value.Year == DateTime.Now.Year)
            {
                _date = value;
            }
        }
    }

    public Order(string item, DateTime date)
    {
        Item = item;
        Date = date;
    }
}

// Fifth assignment
public class DailyAccountState
{
    public int InitialState { get; }

    public int SumOfOperations { get; }

    public DailyAccountState(int initialState, int sumOfOperations)
    {
        InitialState = initialState;
        SumOfOperations = sumOfOperations;
    }

    public int EndOfDayState => InitialState + SumOfOperations;

    public string Report =>
        $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
}
