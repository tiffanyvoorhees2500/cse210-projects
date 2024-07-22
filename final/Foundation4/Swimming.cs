public class Swimming : Activity
{
    private decimal _numberOfLaps;

    public Swimming(DateOnly date, decimal numberMinutes, decimal numberOfLaps)
        : base(date, numberMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override decimal CalculateDistance()
    {
        return _numberOfLaps * 50 / 1000 * (decimal) 0.62;
    }

    public override decimal CalculateSpeed()
    {
        return CalculateDistance() / _numberMinutes * (decimal) 60;
    }

    public override decimal CalculatePace()
    {
        return _numberMinutes / CalculateDistance();
    }
}