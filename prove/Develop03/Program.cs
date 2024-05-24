// I exceeded the requirements for this assignment by implementing a library of scriptures and that scripture get pulled from randomly. 

using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Creating a new scripture
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        
        int i = 0; // This counts how many times the program loops through the library

        // Main loop for practicing scriptures
        while (i <= scriptureLibrary.GetScriptureLibrarySize())
        {
            Scripture currentScripture = scriptureLibrary.GetRandomScripture();
            PracticeScripture(currentScripture);

            i++;

            if (i < scriptureLibrary.GetScriptureLibrarySize())
            {
                Console.WriteLine("\nPress Enter to practice another scripture or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
            }
        }

        Console.WriteLine("\nProgram ended. You have memorized it all! Congrats!");
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
                break;
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