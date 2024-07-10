public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string shortDescription, int points) : base(name, shortDescription, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {

    }
    public override bool IsCompleted()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}