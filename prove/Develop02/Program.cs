using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        //Prompt object
        PromptGenerator prompt = new PromptGenerator();
        //Journal Object
        Journal journal = new Journal();
        //Variable to hold user choice
        int userChoice = 0; //0 means user has not selected an option yet

        do
        {
            //Menu Items for user
            Console.WriteLine("");
            Console.WriteLine("Please choose what you would like to do:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write(">");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                //Date for entry
                DateTime theCurrentDate = DateTime.Now;
                string dateText = theCurrentDate.ToShortDateString();
                string timeText = theCurrentDate.ToShortTimeString();

                //New Journal Entry
                Entry anEntry = new Entry();

                //Set Entry variable values
                anEntry._date = dateText;
                anEntry._time = timeText;
                anEntry._promptText = prompt.GetRandomPrompt();
                //display the random prompt
                Console.WriteLine(anEntry._promptText);
                string userResponse = Console.ReadLine();
                //Save users response to prompt
                anEntry._entryText = userResponse;

                //Add entry to journal
                journal.AddEntry(anEntry);
                Console.WriteLine("-----------------------");
                Console.WriteLine("Your entry has been added. Don't forget to save.");
                Console.WriteLine("-----------------------");
            }
            if (userChoice == 2)
            {
                Console.WriteLine();
                journal.DisplayAll();
                Console.WriteLine();
            }
            if (userChoice == 3)
            {
                Console.WriteLine("What is your text file name?");
                Console.Write(">");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Your entries from {fileName} have been loaded.");
                Console.WriteLine("-----------------------");
            }
            if (userChoice == 4)
            {
                Console.WriteLine("What is your text file name?");
                Console.Write(">");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Your entries have been saved to {fileName}.");
                Console.WriteLine("-----------------------");
            }
            if (userChoice == 5)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Are you sure you want to quit.  Any unsaved entries will be lost. (Y/N)");
                Console.Write(">");
                string boolQuit = Console.ReadLine();
                if (boolQuit.Equals("N", StringComparison.CurrentCultureIgnoreCase))
                {
                    userChoice = 0;
                }
            }
        } while (userChoice != 5);
    }
}