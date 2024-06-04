using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 if finished.");
        int userNumber = 0; //Default userNumber
        List<int> numbers = new List<int>();
        int largestNumber = 0;
        int smallestPositive = int.MaxValue;
        do
        {
            userNumber = int.Parse(Console.ReadLine());
            if(userNumber != 0)
            {
                numbers.Add(userNumber);
                if(userNumber > largestNumber)
                {
                    largestNumber = userNumber;
                }
                if(userNumber > 0 && userNumber < smallestPositive)
                {
                    smallestPositive = userNumber;
                }
            }
        } while(userNumber != 0);

        Console.WriteLine($"The sum is: {numbers.AsQueryable().Sum()}.");
        Console.WriteLine($"The average is: {numbers.AsQueryable().Average()}.");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"The sorted list is:");

        foreach(int num in numbers.Order())
        {
            Console.WriteLine($"{num}");
        }
    }
}