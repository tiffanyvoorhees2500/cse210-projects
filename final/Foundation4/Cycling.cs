public class Cycling : Activity
{
    private decimal _speed;

    public Cycling(DateOnly date, decimal numberMinutes, decimal speed)
        : base(date, numberMinutes)
    {
        _speed = speed;
    }

    public override decimal CalculateDistance()
    {
        return _speed * _numberMinutes;
    }

    public override decimal CalculateSpeed()
    {
        return _speed;
    }

    public override decimal CalculatePace()
    {
        return _numberMinutes / CalculateDistance();
    }
}