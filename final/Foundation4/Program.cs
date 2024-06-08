// This is the Exercise Tracking Program 

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create each activity
        Running running= new Running("03 Nov 2022", 30, 3.0);
        Swimming swimming= new Swimming("16 Nov 2023", 40, 20);
        Cycling cycling= new Cycling("12 Jan 2024", 85, 30);

        // Create a list of activities
        List<Activity> activities = new List<Activity> {running, swimming, cycling};

        Console.WriteLine("");
        foreach (Activity activity in activities)
        {
            Console.WriteLine("\t------------------------------------------------------------------------");
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("\t------------------------------------------------------------------------");
            Console.WriteLine();
        } 
    }
}