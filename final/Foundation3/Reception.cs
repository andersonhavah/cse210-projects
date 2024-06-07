// This is the reception (event) class

using System;

public class Reception : Event
{
    // This is the member variable of this class
    private string _rsvpEmail;

    // This is the constructor of the class
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // This method returns rsvpEmail
    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }

    // This method returns the standard details of the Reception event
    public string GetStandardDetails()
    {
        return $"Standard Details: \n\tTitle: {GetTitle()}\n\tDescription: {GetDescription()}\n\tDate: {GetDate()}\n\tTime: {GetTime()}\n\tAddress: {GetAddress()}";
    }

    // This method returns the full details of the Reception event
    public string GetFullDetails()
    {
        return $"Full Details: \n\tTitle: {GetTitle()}\n\tDescription: {GetDescription()}\n\tDate: {GetDate()}\n\tTime: {GetTime()}\n\tAddress: {GetAddress()}\n\tRSVP Email: {_rsvpEmail}";
    }

    // This method returns a short description of the Reception event
    public string GetShortDescription()
    {
        return $"Short Description: \n\tEvent Type: {GetType().Name}\n\tTitle: {GetTitle()}\n\tDate: {GetDate()}";
    }
}