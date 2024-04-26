using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool playAgain = false;

        do
        {
            Console.WriteLine("Welcome to Guess the Magic Number Game.");
            // Generate a random magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // This variable holds how many times the user guessed the magic number
            int numberOfGuesses = 0; 

            // Ask the user to guess the magic number
            while (true)
            {
                numberOfGuesses++; // Increment every time the user gets the number wrong
                Console.Write("What is your guess? ");
                int guessedNumber = int.Parse(Console.ReadLine());

                if (magicNumber > guessedNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guessedNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("");
                    break;
                }
            }

            // Displays to the user how many times they guessed the number
            Console.WriteLine($"You guessed the magic number in {numberOfGuesses} attempts.");

            // Ask the user whether or not they want to keep playing
            Console.Write("Do you want to keep playing? (yes or no): ");

            // Get and convert the user input into lowercase
            string playAgainResponse = Console.ReadLine().ToLower(); 

            if (playAgainResponse == "yes") {
                playAgain = true;
            }
            else if (playAgainResponse == "no") {
                playAgain = false;
                Console.WriteLine("Thank you for playing!");
            }
            else {
                Console.WriteLine("Wrong input!");
            }

        } while (playAgain);
    }
}