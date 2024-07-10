public class ChecklistGoal : Goal
{
    private int _timesComplete;
    private int _targetTimes;
    private int _bonus;

    public ChecklistGoal(string name, string shortDescription, int points, int targetTimes, int bonus) : base(name, shortDescription, points)
    {
        _timesComplete = 0;
        _targetTimes = targetTimes;
        _bonus = bonus;
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