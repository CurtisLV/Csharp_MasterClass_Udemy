class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int num)
    {
        return num > 0;
    }
}

