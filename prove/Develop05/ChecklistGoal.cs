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
    public ChecklistGoal(string name, string shortDescription, int points,int timesComplete, int targetTimes, int bonus) : base(name, shortDescription, points)
    {
        _timesComplete = timesComplete;
        _targetTimes = targetTimes;
        _bonus = bonus;
    }

    public override int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _timesComplete++;
    }
    public override bool IsCompleted()
    {
        if(_timesComplete >= _targetTimes)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetGoalDetails()
    {
        return $"{_name} ({_shortDescription} --- Currently completed: {_timesComplete}/{_targetTimes})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_shortDescription}|{_points}|{_timesComplete}|{_targetTimes}|{_bonus}";
    }

    public override void ResetGoal()
    {
        _timesComplete = 0;
    }
}