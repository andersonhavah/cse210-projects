// This is the product class for the online order program

using System;

public class Product
{
    // Below are the member variables
    private string _productName;
    private string _productId;
    private decimal _productPrice;
    private int _productQuantity;

    // This is the constructor
    public Product(string productName, string productId, decimal productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    // This method returns the total cost of the products
    public decimal GetTotalCost()
    {
        return _productPrice * _productQuantity;
    }

    // This function returns the product name
    public string GetProductName()
    {
        return _productName;
    }

    // This function returns the product Id
    public string GetProductId()
    {
        return _productId;
    }

    // This function returns the product price
    public decimal GetProductPrice()
    {
        return _productPrice;
    }

    // This function returns the product quantity
    public int GetProductQuantity()
    {
        return _productQuantity;
    }



}