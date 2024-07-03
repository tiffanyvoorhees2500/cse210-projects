public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _followupPrompts;

    public ReflectionActivity(string description, int duration, string activityName)
        : base(description, duration, activityName)
    {

    }
    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomFollowup()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayFollowup()
    {

    }
}