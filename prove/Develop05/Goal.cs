// This is the goal class which is an abstract class
using System;

public abstract class Goal
{
    // These are the member variables of the goal class
    protected string _shortName;
    protected string _description;
    protected int _points;

    // This is the constructor of the goal class with three parameters
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Below are the getters and setters of the member variables
    public string GetShortName()
    {
        return _shortName;
    }

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    // These are abstract method that will be implemented accordingly in each derived class
    public abstract void RecordEvent();
    public abstract bool IsComplete();

    // This method returns the details of the goal
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Points: {_points}";
    }

    // This method returns all details of the goal that could be saved in a file  
    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}: {_shortName}, {_description}, {_points}";
    }

}