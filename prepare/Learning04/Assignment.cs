public class Assignment{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    private string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{GetStudentName()} - {GetTopic()}";
    }
}