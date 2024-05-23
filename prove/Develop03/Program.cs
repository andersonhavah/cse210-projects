// I exceeded the requirements for this assignment by implementing a library of scriptures and scripture get pulled from randomly.

using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Creating a new scripture
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

        // Main loop for practicing scriptures
        while (true)
        {
            Scripture currentScripture = scriptureLibrary.GetRandomScripture();
            PracticeScripture(currentScripture);

            Console.WriteLine("\nPress Enter to practice another scripture or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
        }

        Console.WriteLine("\nProgram ended. Press any key to exit.");
        Console.ReadKey();
    }

    static void PracticeScripture(Scripture scripture)
    {
        Console.Clear();
        DisplayScripture(scripture);

        // Practice loop for hiding words
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                return;
            }

            // Hide a few random words
            scripture.HideRandomWords(2);

            // Display the updated scripture
            DisplayScripture(scripture);
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}