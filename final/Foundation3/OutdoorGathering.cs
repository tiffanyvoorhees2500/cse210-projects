public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateOnly date, TimeOnly time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        _weather = weatherStatement;
    }

    public override string GetFullDetails()
    {
        return $"{GetShortDescription()}\r\n{_weather}";
    }
}