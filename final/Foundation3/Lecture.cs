using System;

public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string eventTitle, string description, string date, string time, Address address, string speakerName, int capacity) : base (eventTitle, description, date, time, address)
    {
        _typeEvent = "Lecture";
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetStandardDetails()
    {
        string standardDetails = $"Topic: {_eventTitle} \n{_description} \nDate: {_date} \nTime: {_time} \nAddress: \n{_address.GetAddressString()}";
        
        return standardDetails;
    }
    

    public override string GetFullDetails()
    {
        string fullDetails = $"{_typeEvent}: {_eventTitle} by {_speakerName}. \n{_description} \nDate: {_date} \nTime: {_time} \nCapacity: {_capacity} places. \nAddress: \n{_address.GetAddressString()}";

        return fullDetails;
    }
}