using System;

public class Swimming : Activity
{
    private double _numberLaps;

    public Swimming( DateTime date, int timeDedicated, double numberLaps) : base (date, timeDedicated)
    {
        _activityType = "Swimming";
        _numberLaps = numberLaps;
    }

    public override double CalculateDistance() // Not in running
    {
        double distance = _numberLaps * 50 / 1000 * 0.62;

        return distance;
    }

}