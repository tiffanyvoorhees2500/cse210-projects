public class Word
{
    private string _word;
    private bool _isHidden;

    //Getters and Setters
    private string GetWord()
    {
        return _word;
    }
    private void SetWord(string word)
    {
        _word = word;
    }

    private bool GetIsHidden(){
        return _isHidden;
    }
    private void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }


    //Constructors
    public Word(string word)
    {
        SetWord(word);
        SetIsHidden(false);
    }


    //Methods
    public void Hide()
    {
        SetIsHidden(true);
    }


    public string GetDisplayText()
    {
        string word = GetWord();
        if(GetIsHidden()==false)
        {
            return word;
        }
        else
        {
            string underscoreWord = "";
            foreach(char letter in word.ToCharArray())
            {
               underscoreWord += "_"; 
            }
            return underscoreWord;
        }
    }

    public bool IsHidden()
    {
        return GetIsHidden();
    }
}