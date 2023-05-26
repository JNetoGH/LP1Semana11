using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
            
            Random random = new Random(); // Generate a random number
            int targetNumber = random.Next(1, 101);  // Generate a number between 1 and 100
            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

            // Game loop
            while (!guessedCorrectly)
            {
                Console.Write("Take a guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;
                
                if (guess == targetNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number correctly!");
                    Console.WriteLine("Number of attempts: " + attempts);
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber) Console.WriteLine("Too low! Try again.");
                else Console.WriteLine("Too high! Try again.");
            }

            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}