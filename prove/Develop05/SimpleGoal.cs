public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string shortDescription, int points) : base(name, shortDescription, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string shortDescription, int points, bool isComplete) : base(name, shortDescription, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsCompleted()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_shortDescription}|{_points}|{_isComplete}";
    }

    public override void ResetGoal()
    {
        _isComplete = false;
    }
}