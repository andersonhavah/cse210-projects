// This is the eternal goal class
using System;


public class EternalGoal : Goal
{
    // This is the constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        // Eternal goals don't get marked as complete
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    // This method returns all details of the Eternal Goal
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_shortName}, {_description}, {_points}";
    }
}