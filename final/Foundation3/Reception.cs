public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetShortDescription()}\r\n\r\nRSVP to: {_rsvpEmail}";
    }
}