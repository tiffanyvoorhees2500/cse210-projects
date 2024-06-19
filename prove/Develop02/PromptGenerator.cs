using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

        //Create a random object
        Random random = new Random();
        //Generate a random number that must be less than the List of prompts
        int index = random.Next(_prompts.Count);
        return $"{_prompts[index]}";
    }

}