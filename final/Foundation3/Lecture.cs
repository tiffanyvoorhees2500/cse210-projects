public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateOnly date, TimeOnly time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetType()}\r\n{GetShortDescription()}\r\n\r\nSPEAKER: {_speaker}\r\nOnly {_capacity} seats available";
    }
}