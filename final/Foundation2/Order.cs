using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private float _totalCost;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public float GetTotalCost()
    {
        return _totalCost;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProductInfo());
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetCustomerInfo()); ;
    }

    public float CalculateTotalCost()
    {
        float shippingCost;

        foreach (Product product in _products)
        {
            float unitCost = product.CalculateTotalProductCost();

            _totalCost += unitCost;
        }

        if (_customer.IsUSALocated())
        {
            shippingCost = 5;
        }

        else
        {
            shippingCost = 35;
        }

        _totalCost += shippingCost;

        return _totalCost;
    }

}