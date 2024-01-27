using System;

public class Product
{
    private string _name;
    private string _productID;
    private float _price;
    private int _quantity;

    public Product(string name, string productID, float price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public float CalculateTotalProductCost()
    {
        float total = _price * _quantity;

        return total;
    }

    public string GetProductInfo()
    {
        string product =$"{_name} \n  ID: {_productID}";

        return product;
    }


}