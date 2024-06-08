// This is the activity class. This is the base class that other activities classes will inherit

using System;

public class Activity
{
    // Below are the member variables
    private string _date;
    private int _length;

    // This is the constructor
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    // This is a virtual method to get the distance that can be overridden by the class that
    // inherits it
    public virtual double GetDistance()
    {
        return 0.0;
    }
    
    // This is a virtual method to get the speed
    public virtual double GetSpeed()
    {
        return 0.0;
    }

    // This is a virtual to get the pace
    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_length} min)";
    }

    // This method returns the value of the member variable "_length" 
    public int GetLength()
    {
        return _length;
    }

    // This method returns the value of the member variable "_date" 
    public string GetDate()
    {
        return _date;
    }
}
