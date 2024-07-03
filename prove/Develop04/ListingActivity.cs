public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string description, int duration, string activityName)
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

    public List<string> GetListFromUser()
    {
        List <string> userList = new List<string>();
        return userList;
    }
}