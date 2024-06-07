// This is the address class for the online ordering program

using System;

public class Address
{
    // Below are the member variables of the Address class
    private string _street;
    private string _city;
    private string _state;
    private int _zipcode;
    private string _country;

    // This is the constructor of the Address class with five parameters
    public Address(string street, string city, string state, int zipcode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
        _country = country;
    }

    // This method returns the address in a full form
    public string GetFullAddressForm()
    {
        return $"\n\t\t{_street}, {_city}, \n\t\t{_state} {_zipcode}, \n\t\t{_country}";
    }

    // Below are the getters and setters for the member variables
    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public int GetZipCode()
    {
        return _zipcode;
    }

    public void SetZipCode(int zipCode)
    {
        _zipcode = zipCode;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
}