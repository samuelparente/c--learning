//Samuel Parente - C# programming exercises

using System;

namespace NumberGuessingGame
{
    class GuessNumberGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guessing Game");
            Console.WriteLine("Guess a number between 1 and 100.");

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            int maxAttempts = 5; // Maximum number of attempts allowed
            bool correctGuess = false;

            while (!correctGuess && attempts < maxAttempts)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high. Try again.");
                }
                else
                {
                    correctGuess = true;
                    Console.WriteLine($"Congratulations! You guessed the number {secretNumber} correctly in {attempts} attempts.");
                }
            }

            if (!correctGuess)
            {
                Console.WriteLine($"Sorry, you did not guess the number within {maxAttempts} attempts. The correct number was {secretNumber}.");
            }
        }
    }
}
