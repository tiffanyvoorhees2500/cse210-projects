using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [];

        Console.Clear();
        Running running = new Running(new DateOnly(2024,7,22),30,3);
        activities.Add(running);

        Cycling cycling = new Cycling(new DateOnly(2024,7,21),30,15);
        activities.Add(cycling);

        Swimming swimming = new Swimming(new DateOnly(2024,7,19),15,6);
        activities.Add(swimming);

        Console.Clear();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("");
        }
    }
}