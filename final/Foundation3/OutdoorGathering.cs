using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;


    public OutdoorGathering(string eventTitle, string description, string date, string time, Address address, string weatherForecast) : base (eventTitle, description, date, time, address)
    {
        _typeEvent = "Outdoor Gathering";
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        string fullDetails = $"{_typeEvent}: {_eventTitle} \n{_description} \nDate: {_date} \nTime: {_time} \nWeather: {_weatherForecast} \nAddress: \n{_address.GetAddressString()}";

        return fullDetails;
    }
}