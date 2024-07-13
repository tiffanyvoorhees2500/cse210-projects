public abstract class Goal
{
    protected string _name;
    protected string _shortDescription;
    protected int _points;

    public Goal(string name, string shortDescription, int points)
    {
        _name = name;
        _shortDescription = shortDescription;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual int GetBonus()
    {
        return 0;
    }

    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public abstract void ResetGoal();
    public virtual string GetGoalDetails()
    {
        return $"{_name} ({_shortDescription})";
    }
    public abstract string GetStringRepresentation();
}