public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    private string GetTextbookSection()
    {
        return _textbookSection;
    }

    private string GetProblems()
    {
        return _problems;
    }



    public string GetHomeworkList()
    {
        return $"Section {GetTextbookSection()} Problems {GetProblems()}";
    }
}