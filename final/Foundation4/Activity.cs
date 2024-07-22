public abstract class Activity
{
    private DateOnly _date;
    protected decimal _numberMinutes;

    public Activity(DateOnly date, decimal numberMinutes)
    {
        _date = date;
        _numberMinutes = numberMinutes;
    }

    public abstract decimal CalculateDistance();
    public abstract decimal CalculateSpeed();

    public abstract decimal CalculatePace();

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType()} ({_numberMinutes} minutes)- Distance: {CalculateDistance().ToString("0.0")} miles, Speed: {CalculateSpeed().ToString("0.0")} mph, Pace: {CalculatePace().ToString("0.0")} min per mile";
    }
    
}