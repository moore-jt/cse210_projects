using System;

class Program
{
    static void Main(string[] args)
    {   
        string playAgain = "y";
        while (playAgain == "y")
        {
            // Generate random number and set magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guessCount = 0;

            // Receive user input to guess the number
            Console.WriteLine("What is your guess?");
            int guess;
            int.TryParse(Console.ReadLine(), out guess);

            // Loop until user guesses the number
            while (guess != magicNumber)
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    int.TryParse(Console.ReadLine(), out guess);
                    guessCount++;
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    int.TryParse(Console.ReadLine(), out guess);
                    guessCount++;
                }
                else
                {
                    break;
                }
            }

            // Ending text
            Console.WriteLine($"You guessed it in {guessCount} guesses!\nDo you want to play again? (y/n)");
            playAgain = Console.ReadLine();
            
        }
        Console.WriteLine("Thanks for playing! Come again!");

    }
}
