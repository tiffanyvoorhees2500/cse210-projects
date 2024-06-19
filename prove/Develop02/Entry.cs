public class Entry
{
    public string _date;
    public string _time;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} @ {_time}:");
        Console.WriteLine($"PROMPT: {_promptText}");
        Console.WriteLine($"RESPONSE: {_entryText}");
        Console.WriteLine("");
    }

    public string WriteToFile()
    {
        return $"{_date}|{_time}|{_promptText}|{_entryText}";
    }
}