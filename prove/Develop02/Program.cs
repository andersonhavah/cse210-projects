/*
 For this assignment, I exceeded the requirements by saving more information in the journal entry. To enhance the Journal Program further, I modified the Entry class to allow users to save additional information along with their journal entries. I added the ability to include a "Location" and "Mood" for each entry. Users can then provide the location where the entry was made and their mood at the time of writing.
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new journal
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // Adding sample prompts to the promptGenerator
        promptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
        promptGenerator._prompts.Add("What was the best part of my day?");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGenerator._prompts.Add("What was the strongest emotion I felt today?");
        promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");
        promptGenerator._prompts.Add("What are you grateful for today?");
        promptGenerator._prompts.Add("What have you accomplished today toward one of your goals?");
        promptGenerator._prompts.Add("What is one positive thing that happened today at work?");
        promptGenerator._prompts.Add("What is one negative thing that happened today at work?");
        promptGenerator._prompts.Add("What are you most proud of today?");
        promptGenerator._prompts.Add("What would it be if you had one thing to say to someone you love?");
        promptGenerator._prompts.Add("What is your takeaway from the day you had?");


        // A welcome message to the Journal Program
        Console.WriteLine("\n===== Welcome to the Journal Program! =====");

        bool continueProgram = true;
        while (continueProgram)
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("\nEnter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{randomPrompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    Console.WriteLine("Enter location: ");
                    Console.Write("> ");
                    string location = Console.ReadLine();
                    Console.WriteLine("Enter mood: ");
                    Console.Write("> ");
                    string mood = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry newEntry = new Entry(date, randomPrompt, response, location, mood);
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "5":
                    continueProgram = false;
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.\n");
                    break;
            }
        }

    }
}