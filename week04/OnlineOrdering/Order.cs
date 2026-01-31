using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Apply shipping cost if the customer is not in the USA
        if (_customer.LivesInUSA())
        {
            totalCost += 5.00; // Flat shipping fee for international orders
        }
        else
        {
            totalCost += 35.00; // Flat shipping fee for domestic orders
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        Address address = _customer.GetAddress();
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetName()}\n";
        shippingLabel += address.GetFullAddress();
        return shippingLabel;
    }
}