// This is the order class for the online ordering program
using System;

public class Order
{
    // Below are the member variables
    private List<Product> _products;
    private Customer _customer;

    // This is the constructor
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // This method returns the total cost 
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += _customer.IsCustomerInUSA() ? 5 : 35;
        return totalCost;
    }

    // This method returns the packing label
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:";
        foreach (Product product in _products)
        {
            packingLabel += $"  {product.GetProductName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    // This method returns the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n  Customer Name: {_customer.GetCustomerName()}\n  Customer Address: {_customer.GetCustomerAddress()}";
    }
}