using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squared = SquareNumber(favNumber);

        DisplayResult(userName,squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number){
        return number * number;
    }

    static void DisplayResult(string userName, int squareNumber){
        Console.WriteLine($"Welcome {userName}. You're favorite number squared is: {squareNumber}");
    }
}