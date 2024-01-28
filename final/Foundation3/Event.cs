using System;

public abstract class Event
{
    protected string _typeEvent;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        string standardDetails = $"{_eventTitle} \n{_description} \nDate: {_date} \nTime: {_time} \nAddress: \n{_address.GetAddressString()}";
        
        return standardDetails;
    }

    public string GetShortDescription()
    {
        string shortDescription = $"{_typeEvent} \n{_eventTitle} \nDate: {_date}";

        return shortDescription;
    }

    public abstract string GetFullDetails();
}