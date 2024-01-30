using System;

public class Running : Activity
{
    private double _distance;

    public Running( DateTime date, int timeDedicated, double distance) : base (date, timeDedicated)
    {
        _activityType = "Running";
        _distance = distance;
    }

    public override double CalculateDistance() // Not in running
    {
        return _distance;
    }
}