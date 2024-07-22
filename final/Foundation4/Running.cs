public class Running : Activity
{
    private decimal _distance;

    public Running(DateOnly date, decimal numberMinutes, decimal distance)
        : base(date, numberMinutes)
    {
        _distance = distance;
    }

    public override decimal CalculateDistance()
    {
        return _distance;
    }

    public override decimal CalculateSpeed()
    {
        return _distance / _numberMinutes * (decimal) 60;
    }

    public override decimal CalculatePace()
    {
        return _numberMinutes / _distance;
    }
}