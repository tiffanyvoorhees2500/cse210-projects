
public class Activity
{
    private string _description;
    private int _duration;
    private string _activityName;

    public Activity(string description, int duration, string activityName)
    {
        _description = description;
        _duration = duration;
        _activityName = activityName;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        DisplayReadySetGo();
    }

    public void DisplayFinalMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        DisplaySpinner(4);

        Console.WriteLine("");
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName}");
        DisplaySpinner(4);
        Console.Clear();
    }

    public void DisplayReadySetGo()
    {
        Console.WriteLine("Ready");
        DisplaySpinner(2);

        Console.Clear();

        Console.WriteLine("Set");
        DisplaySpinner(2);

        Console.Clear();

        Console.WriteLine("Go");
    }

    public void DisplaySpinner(int numSeconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numSeconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count())
            {
                i = 0;
            }
        }
    }

    public void DisplayCounter(int maxNumber)
    {
        for (int i = maxNumber; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}