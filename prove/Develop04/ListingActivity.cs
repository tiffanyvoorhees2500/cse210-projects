using System.Diagnostics.CodeAnalysis;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string description, int duration, string activityName)
        : base(description, duration, activityName)
    {
        AddPrompt("Who are people that you appreciate?");
        AddPrompt("What are personal strengths of yours");
        AddPrompt("When have you felt the Holy Ghost this month?");
        AddPrompt("Who are some of your personal heros?");
    }

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }
    public void Run()
    {
        DisplayWelcomeMessage();

        Console.WriteLine("");

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        DisplayCounter(4);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");

        DisplayFinalMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        string prompt = _prompts[index];

        return prompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        return userList;
    }
}