// This is the outdoor gathering class

using System;

public class OutdoorGathering : Event
{
    // This is the member variable
    private string _weatherForecast;

    // This is the constructor
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    // This method returns the standard details of the Reception event
    public string GetStandardDetails()
    {
        return $"Event Information: \n\tTitle: {GetTitle()}\n\tDescription: {GetDescription()}\n\tDate: {GetDate()}\n\tTime: {GetTime()}\n\tAddress: {GetAddress()}";
    }

    // This method returns the full details of the Reception event
    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n\tWeather Forecast: {_weatherForecast}";
    }

    // This method returns a short description of the Reception event
    public string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
}