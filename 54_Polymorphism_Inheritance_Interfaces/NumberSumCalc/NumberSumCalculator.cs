class NumberSumCalculator
{
    var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
    bool shallAddPositiveOnly = false;

    NumbersSumCalculator calculator = shallAddPositiveOnly
        ? new PositiveNumbersSumCalculator()
        : new NumbersSumCalculator();

    int sum;
    if (shallAddPositiveOnly)
    {
        //sum = new PositiveNumbersSumCalculator().Calculate(numbers);
    }
    else
    {
        //sum = new NumbersSumCalculator().Calculate(numbers);
   
}   
    }

