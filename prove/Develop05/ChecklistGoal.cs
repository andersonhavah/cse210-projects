// This is the checklist goal class
using System;


public class ChecklistGoal : Goal
{
    // These are the member variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // This is the constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: \n\tName: {_shortName}, \n\tDescription: {_description}, \n\tPoints: {_points}, \n\tAmount: {_amountCompleted}, \n\tTarget: {_target}, \n\tBonus: {_bonus}";
    }

    // This method returns the bonus
    public int GetBonus()
    {
        return _bonus;
    }

    // This method returns the target
    public int GetTarget()
    {
        return _target;
    }

    // This method returns the amount completed
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
}