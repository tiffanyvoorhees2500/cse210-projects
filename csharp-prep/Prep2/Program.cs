using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        int percentage = int.Parse(Console.ReadLine());
        
        string letterGrade;

        if(percentage >= 90)
        {
            letterGrade = "A";
        }
        else if(percentage >= 80)
        {
            letterGrade = "B";
        }
        else if(percentage >= 70)
        {
            letterGrade = "C";
        }
        else if(percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        string sign = "";
        int lastDigit = percentage % 10;
        if(letterGrade != "F" && percentage <=93)
        {
            if(lastDigit >= 7)
            {
                sign = "+";
            }
            else if(lastDigit < 3)
            {
                sign = "-";
            }
        }

        string status;
        if(percentage >= 70)
        {
            status = "Congrats! You are passing the class.";
        }
        else
        {
            status = "Keep working. You can do this.";
        }

        Console.WriteLine($"Your grade is: {letterGrade}{sign}. {status}");
    }
}