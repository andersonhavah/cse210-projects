// This is the swimming activity class


using System;

public class Swimming : Activity
{
    // Below are the attributes or member variables of the class
    private int _laps;
    private const double _lapLength = 50.0; // in meters

    // This is the constructor
    public Swimming(string date, int length, int laps) : base (date, length)
    {
        _laps = laps;
    }

    // This method returns the distance in miles
    public override double GetDistance()
    {
        return (_laps * _lapLength) / (1000 * 0.62); // in miles 
    }

    // This method returns the speed 
    public override double GetSpeed()
    {
        return (GetDistance() / base.GetLength()) * 60;
    }

    // This method returns the pace
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

    // This method returns the summary of the running activity including the date, distance, speed, and pace.
     public override string GetSummary()
    {
        return $"Swimming Activity: {base.GetSummary()} - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
