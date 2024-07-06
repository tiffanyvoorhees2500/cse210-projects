using System;

class Program
{
    static void Main(string[] args)
    {
        int menuOption = 0;
        int breathingRuns = 0;
        int reflectionRuns = 0;
        int listingRuns = 0;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start relfecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");

            menuOption = int.Parse(Console.ReadLine());

            switch(menuOption)
            {
                case 1:
                    string breathingDescription = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";
                    BreathingActivity breathingActivity = new BreathingActivity(breathingDescription, 0, "Breathing Activity");

                    breathingActivity.Run();
                    breathingRuns++;

                    break;
                case 2:
                    string reflectingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ReflectionActivity reflectionActivity = new ReflectionActivity(reflectingDescription, 0, "Reflection Activity");

                    reflectionActivity.Run();
                    reflectionRuns++;

                    break;
                case 3:
                    string listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    ListingActivity listingActivity = new ListingActivity(listingDescription, 0, "Listing Activity");

                    listingActivity.Run();
                    listingRuns++;

                    break;
                case 4:
                    break;
                default:
                    break;

            }

            Console.WriteLine("You have completed the following activities:");
            Console.WriteLine($"Breathing: {breathingRuns}");
            Console.WriteLine($"Reflection: {reflectionRuns}");
            Console.WriteLine($"Listing: {listingRuns}");

            Console.WriteLine("");

        }while(menuOption != 4);
    }
}