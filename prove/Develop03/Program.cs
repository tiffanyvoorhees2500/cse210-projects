using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureRefOne = new Reference("Proverbs", 3, 5, 6);
        string scriptureTextOne = "in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture1 = new Scripture(scriptureRefOne, scriptureTextOne);

        string response = "";
        do
        {
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());

            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            response = Console.ReadLine();
            if (response == "")
            {
                scripture1.HideRandomWords(3);
            }
        } while (response != "quit" && scripture1.IsCompletelyHidden() == false);

        if (scripture1.IsCompletelyHidden() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Congratulations!  Looks like you might have it memorized!");
        }
        else
        {
            Console.Clear();

        }
    }
}