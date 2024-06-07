// This is the lecture (an event) class that inherit the Event class

using System;

public class Lecture : Event
{
    // Below are the member variables
    private string _speaker;
    private int _capacity;

    // This is the constructor with seven parameters, five of them inherited from the base class
    public Lecture (string title, string description, string date, string time, Address address,string speaker, int capacity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // This method returns the standard details of the Lecture event
    public string GetStandardDetails()
    {
        return $"Standard Details: \n\tTitle: {GetTitle()}\n\tDescription: {GetDescription()}\n\tDate: {GetDate()}\n\tTime: {GetTime()}\n\tAddress: {GetAddress()}";
    }

    // This method returns the full details of the Lecture event
    public string GetFullDetails()
    {
        return $"Full Details: \n\tTitle: {GetTitle()}\n\tDescription: {GetDescription()}\n\tDate: {GetDate()}\n\tTime: {GetTime()}\n\tAddress: {GetAddress()}\n\tSpeaker: {_speaker}\n\tCapacity: {_capacity}";
    }

    // This method returns a short description of the Lecture event
    public string GetShortDescription()
    {
        return $"Short Description: \n\tEvent Type: {GetType().Name}\n\tTitle: {GetTitle()}\n\tDate: {GetDate()}";
    }
}