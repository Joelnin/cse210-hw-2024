using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;    
    }

    public bool IsUSALocated()
    {
        bool USALocated;

        if (_address.IsUSALocated())
        {
            USALocated = true;
        }

        else
        {
            USALocated = false;
        }

        return USALocated;
    }

    public string GetCustomerInfo()
    {
        string customer = $"{_name} \n{_address.GetAddressString()}";

        return customer;
    }
}