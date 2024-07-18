public abstract class Event
{
    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;

    public Event(string title, string description, DateOnly date, TimeOnly time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_title}\r\n{_description}\r\n{_date} @ {_time}\r\n{_address.GetStringRepresentation()}";
    }
    public string GetShortDescription()
    {
        return $"{_title}\r\n{_description}\r\n{_date} @ {_time}";
    }

    public abstract string GetFullDetails();
}