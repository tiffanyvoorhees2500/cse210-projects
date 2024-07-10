public class EternalGoal : Goal
{
    public EternalGoal(string name, string shortDescription, int points) : base(name, shortDescription, points)
    {

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