using System;

public class Reception : Event
{
    private string _email;

        public Reception(string eventTitle, string description, string date, string time, Address address, string email) : base (eventTitle, description, date, time, address)
    {
        _typeEvent = "Reception";
        _email = email;
    }

    public override string GetFullDetails()
    {
        string fullDetails = $"{_typeEvent}: {_eventTitle} \n{_description} \nDate: {_date} \nTime: {_time} \nPlease, RSVP to: {_email} \nAddress: \n{_address.GetAddressString()}";

        return fullDetails;
    }
}