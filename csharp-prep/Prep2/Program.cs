using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Please enter your grade percentage (Eg. 87): ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed! Congrats!");
        }
        else
        {
            Console.WriteLine("Sorry you haven't passed this time! Wish you success next time!");
        }
    }
}