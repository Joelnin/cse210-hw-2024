using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling( DateTime date, int timeDedicated, double speed) : base (date, timeDedicated)
    {
        _activityType = "Cycling";
        _speed = speed;
    }

    public override double CalculateDistance() // Not in running
    {
        double distance = _timeDedicated * CalculateSpeed() / 60;

        return distance;
    }

    public override double CalculateSpeed() // Not in cycling.
    {
        return _speed;
    }


}