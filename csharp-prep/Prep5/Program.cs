using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the functions
        DisplayWelcome();

        String userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }

    // This function displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // This function get the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // This function get the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    // This function computes and return the square of the user's favorite number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // This function displays the result to the user
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}