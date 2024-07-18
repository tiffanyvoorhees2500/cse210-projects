using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberComments()
    {
        return _comments.Count();
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine("************************************************");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} minutes");
        Console.WriteLine($"{GetNumberComments()} COMMENTS:");

        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetStringRepresentation()}");
        }
    }
}