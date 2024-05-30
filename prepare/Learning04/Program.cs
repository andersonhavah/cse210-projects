using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment
        Assignment assignment = new Assignment("John Samuel", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine($"{summary}\n");

        // Math Assignment
        MathAssignment mathAssignment= new MathAssignment("Jack Roberts", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine($"{mathAssignment.GetHomeworkList()}\n");

        // Writing Assignment
        WritingAssignment writingAssignment= new WritingAssignment("Johnson Lockhard", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}