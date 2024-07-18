public class Comment
{
    private string _personName;
    private string _comment;

    public Comment(string personName, string comment)
    {
        _personName = personName;
        _comment = comment;
    }

    public string GetStringRepresentation()
    {
        return $"    {_personName}: {_comment}";
    }
}