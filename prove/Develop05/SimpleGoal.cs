// This is the simple goal class
using System;


public class SimpleGoal : Goal
{
    // This is the member variable of this class
    private bool _isComplete;

    // This is the constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // This method checks whether or not the event is recorded
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // This method returns if the goal is complete or not. 
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // This method returns a detailed information of the simple goal
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + (_isComplete ? " [X]" : " [ ]");
    }

    // This method returns all details about the Simple Goal
    public override string GetStringRepresentation()
    {
        if (_isComplete == true)
        {
            return $"Simple Goal: {_shortName}, {_description}, {_points}, is complete";
        }
        else
        {
            return $"Simple Goal: {_shortName}, {_description}, {_points}, is not complete yet";
        }
    }
}
