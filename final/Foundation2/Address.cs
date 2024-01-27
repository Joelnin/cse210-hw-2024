using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsUSALocated()
    {
        bool USALocated;
        string country = _country.ToLower();

        if (country == "usa" || country == "united states" || country == "united states of america" )
        {
            USALocated = true;
        }

        else
        {
            USALocated = false;
        }

        return USALocated;
    }

    public string GetAddressString()
    {
        string addressString = $"{_street} \n{_city}, {_stateOrProvince} \n{_country}";

        return addressString;
    }

}