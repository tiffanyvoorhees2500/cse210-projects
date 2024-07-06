using System.Configuration.Assemblies;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _followupPrompts = new List<string>();

    public ReflectionActivity(string description, int duration, string activityName)
        : base(description, duration, activityName)
    {
        AddPrompt("Think of a time when you stood up for someone else.");
        AddPrompt("Think of a time when you did something really difficult.");
        AddPrompt("Think of a time when you helped someone in need.");
        AddPrompt("Think of a time when you did smoething truly selfless.");

       AddFollowupPrompt("Why was this experience meaningful to you?");
       AddFollowupPrompt("Have you ever done anthing like this before?");
       AddFollowupPrompt("How did you get started?");
       AddFollowupPrompt("How did you feel when it was complete?");
       AddFollowupPrompt("What made this time different than other times when you were not as successful?");
       AddFollowupPrompt("What is your favorite thing about this experience?");
       AddFollowupPrompt("What could you learn from this experience that applies to other situations?");
       AddFollowupPrompt("What did you learn about yourself through this experience?");
       AddFollowupPrompt("How can you keep this experience in mind in the future?");
    }

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public void AddFollowupPrompt(string followupPrompt)
    {
       _followupPrompts.Add(followupPrompt);
    }

    public void Run()
    {
        DisplayWelcomeMessage();

        Console.WriteLine("");

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            DisplayFollowupPrompt();
            DisplaySpinner(4);
        }

        DisplayFinalMessage();
    }

    public string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        string prompt = prompts[index];
        return prompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt(_prompts)} ---");
    }

    public void DisplayFollowupPrompt()
    {
        Console.WriteLine($"> {GetRandomPrompt(_followupPrompts)}");
    }
}