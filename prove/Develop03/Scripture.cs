using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    //Getters and Setters
    private List<Word> GetWords()
    {
        return _words;
    }
    private void SetWords(List<Word> words)
    {
        _words = words;
    }
    private void AddWord(Word word)
    {
        _words.Add(word);
    }

    private Reference GetReference()
    {
        return _reference;
    }

    //Constructures
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        ConvertStringToList(text);
    }

    //Methods
    private void ConvertStringToList(string text)
    {
        List<string> listWords = text.Split(" ").ToList();

        foreach (string newWord in listWords)
        {
            Word listWord = new Word(newWord);
            AddWord(listWord);
        }
    }

    public string GetDisplayText()
    {
        string displayReference = $"{GetReference().GetDisplayText()}";
        string newScriptureText = "";
        foreach (Word word in GetWords())
        {
            newScriptureText += $" {word.GetDisplayText()}";
        }

        return $"{displayReference}:{newScriptureText}";
    }

    public void HideRandomWords(int numOfWords)
    {
        //Create a random object
        Random random = new Random();

        for(int i=0; i<numOfWords; i++)
        {
            bool alreadyHidden = false;
            do
            {
                //Generate a random number that must be less than the List of prompts
                int index = random.Next(_words.Count);
                Word word = _words[index];
                if(word.IsHidden() == false)
                {
                    alreadyHidden = false;
                    word.Hide();
                }
                else
                {
                    alreadyHidden = true;
                }
            } while(alreadyHidden == true && IsCompletelyHidden() == false);
        }
    }

    public bool IsCompletelyHidden()
    {
        bool isHidden = true;
        foreach (Word word in GetWords())
        {
            if (word.IsHidden() == false)
            {
                isHidden = false;
            }
        }

        return isHidden;
    }
}