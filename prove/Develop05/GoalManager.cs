// This is the goal manager class
using System;
using System.Collections.Generic;

public class GoalManager
{
    // These are the member variables
    private List<Goal> _goals;
    private int _score;

    // This is the constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // This method starts the program
    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalsDetails();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals("goals.txt");
                    break;
                case "6":
                    LoadGoals("goals.txt");
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }


    // This function displays the score to the player
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    // This method lists the details of the goal to the user
    public void ListGoalsDetails()
    {
        if (_goals.Count() != 0)
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }
        else
        {
            Console.WriteLine("The goal list is empty.");
            Console.WriteLine();
        }

    }

    // This method creates a new goal
    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select an option: ");
        string choice = Console.ReadLine();

        Console.WriteLine("");
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine();
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    // This method records an event for a defined goal 
    public void RecordEvent()
    {
        Console.WriteLine("");
        Console.Write("Enter goal name to record event: ");
        string goalName = Console.ReadLine();
        var goal = _goals.Find(g => g.GetType().Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal.IsComplete() ? goal.GetPoints() : 0;
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonus();
            }
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    // This function saves goals to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    // This functio loads goals from a file
    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            _goals.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string goalType = parts[0];
                string[] goalDetails = parts[1].Split(',');

                if (goalType == nameof(SimpleGoal))
                {
                    Goal goal = new SimpleGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2]));
                    if (bool.Parse(goalDetails[3])) goal.RecordEvent();
                    _goals.Add(goal);
                }
                else if (goalType == nameof(EternalGoal))
                {
                    _goals.Add(new EternalGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2])));
                }
                else if (goalType == nameof(ChecklistGoal))
                {
                    Goal goal = new ChecklistGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2]), int.Parse(goalDetails[3]), int.Parse(goalDetails[4]));
                    for (int j = 0; j < int.Parse(goalDetails[3]); j++)
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
            }
        }
    }

}