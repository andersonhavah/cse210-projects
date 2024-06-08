// This is the running activity class

using System;

public class Running : Activity
{
    // This is the member variable of the Running class
    private double _distance; // in miles

    // This is the constructor of the Running class
    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    // This method returns the distance of the running activity
    public override double GetDistance()
    {
        return _distance;
    }

    // This method returns the speed of the running activity
    public override double GetSpeed()
    {
        return _distance / GetLength() * 60;
    }

    // The GetPace() method returns the pace for the running activity
    public override double GetPace()
    {
        return GetLength() / _distance;
    }

    // This method returns the summary of the running activity including the date, distance, speed, and pace.
    public override string GetSummary()
    {
        return $"Running Activity: {base.GetSummary()} - Distance: {_distance} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }


}
