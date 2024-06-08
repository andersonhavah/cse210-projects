// This is the cycling activity class

using System;

public class Cycling : Activity
{
    // This is the member variable of the class
    private double _speed; // in mph

    // This is the constructor
    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    // This method returns the distance in miles
    public override double GetDistance()
    {
        return (_speed * GetLength()) / 60;
    }

    // The GetSpeed() method returns the speed in miles per hour (mph) for the cycling activity
    public override double GetSpeed()
    {
        return _speed;
    }

    // The GetPace() method returns the pace for the cycling activity
    public override double GetPace()
    {
        return 60 / _speed;
    }

    // This method returns the summary of the cycling activity including the date, distance, speed, and pace.
    public override string GetSummary()
    {
        return $"Cycling Activity: {base.GetSummary()} - Distance: {GetDistance():F2} miles, Speed: {_speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }
}