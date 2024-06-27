public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Getters and Setters
    private string GetBook()
    {
        return _book;
    }
    private void SetBook(string book)
    {
        _book = book;
    }

    private int GetChapter()
    {
        return _chapter;
    }
    private void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    private int GetStartVerse()
    {
        return _startVerse;
    }
    private void SetStartVerse(int startVerse)
    {
        _startVerse = startVerse;
    }

    private int GetEndVerse()
    {
        return _endVerse;
    }
    private void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    //Constructors
    public Reference(string book, int chapter, int verse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetStartVerse(verse);
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetStartVerse(startVerse);
        SetEndVerse(endVerse);
    }

    //Methods
    private string GetVerseText()
    {
        int startVerse = GetStartVerse();
        int endVerse = GetEndVerse();
        if (endVerse > 0)
        {
            return $"{startVerse}-{endVerse}";
        }
        else
        {
            return $"{startVerse}";
        }
    }

    public string GetDisplayText()
    {
        return $"{GetBook()} {GetChapter()}:{GetVerseText()}";
    }
}