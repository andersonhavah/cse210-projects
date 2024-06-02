// I exceeded the requirements by implementing and displaying to the user how many times they performed the activities before quitting program.

using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning =  true;
        int numberOfTimesPlayed = 0;
        // A welcome message to the program
        Console.WriteLine("\nWelcome to the Mindfulness Program!");

        while (keepRunning)
        {
            
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            // Activity activity;
            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    numberOfTimesPlayed++;
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    numberOfTimesPlayed++;
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    numberOfTimesPlayed++;
                    break;
                case 4:
                    Console.WriteLine("\nBye! See you next time!");
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Type a valid choice (1-4)\n");
                    keepRunning = true;
                    break;
            }
        }

        Console.WriteLine($"You performed the activities {numberOfTimesPlayed} times!");

    }
}