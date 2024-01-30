using System;
using System.Globalization;

public abstract class Activity
{
    protected DateTime  _date;
    protected int _timeDedicated;
    protected string _activityType;

    public Activity( DateTime date, int timeDedicated)
    {
        _date = date;
        _timeDedicated = timeDedicated;
    }

    public abstract double CalculateDistance(); // Everyone needs to get its own.

    public virtual double CalculateSpeed() // Not in cycling.
    {
        double speed = (CalculateDistance() / _timeDedicated) * 60;

        return speed;
    }

    public double CalculatePace() // Everyone needs it.
    {
        double pace = 60 / CalculateSpeed();

        return pace;
    }

    public string FormatDate()
    {
        CultureInfo culture = new CultureInfo("en-US");

        DateTimeFormatInfo dateFormat = culture.DateTimeFormat;

        string formattedDate = _date.ToString("dd MMM yyyy", dateFormat);

        return formattedDate;
    }

    public string GetSummary() // Everyone needs it.
    {
        string summary = $"{FormatDate()} {_activityType} ({_timeDedicated} min)- Distance {CalculateDistance():N1} miles, Speed {CalculateSpeed():N1} mph, Pace: {CalculatePace():N1} min per mile";
        
        return summary;
    }
}