using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points) // The eternal Goal are like basic Goals. Most of it attributes are from the base class.
    {
    }

    public override int RecordEvent() // Rewards for doing the action.
    {
        return _points; // Just return the points earned.
    }

    public override bool IsComplete() // To know if the Goal has been reached.
    {
        bool completed = false; // The eternal goals are never completed.

        return completed; // Return status.
    }

    public override string GetStringRepresentation() // This is how it is going to be formatted in the document to be saved later.
    {
        string stringRepresentation = $"EternalGoal //#// {_shortName} /// {_description} /// {_points}";

        return stringRepresentation; // It returns a string with the correct format.
    }

}