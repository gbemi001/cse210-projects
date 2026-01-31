using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private double _price;
    private string _productId;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _price = price;
        _productId = productId;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductId()
    {
        return _productId;
    }

}