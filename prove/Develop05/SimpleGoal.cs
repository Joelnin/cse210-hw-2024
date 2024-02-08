using System;

public class SimpleGoal : Goal
{
    private bool _isComplete; // Status of the goal.

    public SimpleGoal(string name, string description, int points, bool status) : base (name, description, points)
    {
        _isComplete = status;
    }

    public override int RecordEvent() // Rewards for doing the action.
    { 
        _isComplete = true; // Mark as completed.

        return _points; // Return the points earned for the action.
    }

    public override bool IsComplete()
    {
        bool completed; // Creating a variable to verify status.

        if (_isComplete) // If the goal is completed.
        {
            completed = true; // Return that it is completed.
        }

        else // If it is not completed.
        {
            completed = false; // Return that it is not completed.
        }

        return completed; // Return status.
    }

    public override string GetStringRepresentation() // This is how it is going to be formatted in the document to be saved later.
    {
        string stringRepresentation = $"SimpleGoal //#// {_shortName} /// {_description} /// {_points} /// {_isComplete}";

        return stringRepresentation; // It returns a string with the correct format.
    }

}