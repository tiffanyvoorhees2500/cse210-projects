using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);
        
        int guess = 0;
        int numGuesses = 0;
        string playAgain = "Yes";
        while(playAgain == "Yes")
        {
            do
            {
                Console.Write("Guess a number between 1 and 11. What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if(guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if(guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                numGuesses++;

            } while(guess != magicNumber);

            Console.WriteLine("Congratulations!  You guessed correctly.");
            Console.Write("Would you like to play again? (Yes/No) ");
            playAgain = Console.ReadLine();
        }
    }
}