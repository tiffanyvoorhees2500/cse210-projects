public abstract class Goal
{
    private string _name;
    private string _shortDescription;
    private int _points;

    public Goal(string name, string shortDescription, int points)
    {
        _name = name;
        _shortDescription = shortDescription;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public string GetGoalDetails()
    {
        return "";
    }
    public abstract string GetStringRepresentation();
}