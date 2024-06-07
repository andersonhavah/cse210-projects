// This is the customer class for the online ordering program
using System;

public class Customer
{
    // Below are the member variables
    private string _customerName;
    private Address _customerAddress;

    // This is the constructor
    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    // This function checks if the customer is in or out of USA
    public bool IsCustomerInUSA()
    {
        return _customerAddress.IsAddressInUSA();
    }

    // This function returns the customer name
    public string GetCustomerName()
    {
        return _customerName;
    }

    // This function returns the customer address
    public string GetCustomerAddress()
    {
        return _customerAddress.GetFullAddressForm();
    }
}