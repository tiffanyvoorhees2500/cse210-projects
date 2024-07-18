using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        //Create Lecture event
        Address addressLecture = new Address("1234 S Saver St.", "Rexburg", "ID", "USA");
        Lecture lecture = new Lecture("Saving your pennies!", "Learn how to budget and make your pennies work for you", new DateOnly(2024, 7, 25), new TimeOnly(10, 0), addressLecture, "Tiffany Voorhees", 25);

        events.Add(lecture);

        //Create Reception event
        Address addressReception = new Address("145 S Marriage Ln", "Mesa", "AZ", "USA");
        Reception reception = new Reception("Scott and Tiffany Voorhees", "Celebrate the marriage of Scott and Tiffany", new DateOnly(2011, 3, 13), new TimeOnly(13, 30), addressReception, "tiff25@byui.edu");

        events.Add(reception);

        //Create Outdoor Gathering
        Address addressGathering = new Address("146 S Marriage Ln", "Mesa", "AZ", "USA");
        OutdoorGathering gathering = new OutdoorGathering("Birthday for Nana V", "Celebrate Nana Voorhees birthday with extended family.", new DateOnly(2025, 6, 21), new TimeOnly(19, 0), addressGathering, "It will be 95 degrees and partly cloudy.");

        events.Add(gathering);

        foreach (Event e in events)
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("******** STANDARD DETAILS ********");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("********** FULL DETAILS **********");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("******* SHORT DESCRIPTION ********");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("**********************************");
            Console.WriteLine("");
        }
    }
}