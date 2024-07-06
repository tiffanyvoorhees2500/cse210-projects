using System.Data;

public class BreathingActivity : Activity
{
    public BreathingActivity(string description, int duration, string activityName)
        : base(description, duration, activityName)
    {

    }
    public void Run()
    {
        DisplayWelcomeMessage();

        Console.WriteLine("");

        int inDuration = 4;
        int outDuration = 6;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breathe In...");
            DisplayCounter(inDuration);

            Console.WriteLine("");

            Console.Write("Breathe Out...");
            DisplayCounter(outDuration);
            Console.WriteLine();
        }

        DisplayFinalMessage();

    }
}