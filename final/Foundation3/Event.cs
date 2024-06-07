// This is the event class for the Event Planning program. This is the base class that other event classes will inherit

using System;

public class Event
{
    // Below are the member variables
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // This is the constructor
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Below are the getters of the member variables
    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _address.GetFullAddressForm();
    }

    
}