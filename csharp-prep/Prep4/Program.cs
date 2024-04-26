using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;

        while (true)
        {
            Console.Write("Enter a number (type 0 to stop):");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbersList.Add(number);
            }
            else
            {
                break;
            }
        }

        // Get the sum of each number added together on the list. 
        int sum = 0;
        foreach (int num in numbersList) {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list
        double average = (double) sum / numbersList.Count; 
        Console.WriteLine($"The average is: {average}");

        // Get the largest number in the list
        numbersList.Sort();
        Console.WriteLine($"The largest number is: {numbersList[numbersList.Count - 1]}");

    
    }
}