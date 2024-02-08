using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted; // It's a checklist so it needs how many times the action has been made.
    private int _target; // This is the target amount of times to reach the goal.
    private int _bonus; // This is the bonus, points aside for reaching the goal.

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base (name, description, points) // Constructor to organize the information and get objects with the correct information.
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent() // Rewards for doing the action.
    {
        _amountCompleted++; // Every time this action is recorded, the amount of actions made is increased by 1.

        int pointsEarned; // Create a variable to return the quantity of points for this action.

        if (_amountCompleted == _target) // If the number of actions made are equal to the target. Return a bonus too.
        {
            pointsEarned = _points + _bonus; // Return the bonus and points for the reached goal.
        }

        else // Otherwise, if the amount of times made is not exactly what it needs to in order to reach the goal, just return the points.
        {
            pointsEarned = _points; // The points earned are just the normal points.
        }

        return pointsEarned; // Return the points earned for the action.
    }

    public override bool IsComplete() // To know if the Goal has been reached.
    {
        bool completed; // This is the variable that will answer the question to the status of the goal.

        if (_amountCompleted >= _target) // If the amount of time the action has been made is more than the needed to acomplished the goal, then it is complete.
        {
            completed = true;
        }
        
        else // Otherwise, it is not complete.
        {
            completed = false;
        }

        return completed; // Return status.
    }

    public override string GetStringRepresentation() // This is how it is going to be formatted in the document to be saved later.
    {
        string stringRepresentation = $"ChecklistGoal //#// {_shortName} /// {_description} /// {_points} /// {_amountCompleted} /// {_target} /// {_bonus}";

        return stringRepresentation; // It returns a string with the correct format.
    }

    public override string GetDetailsString() // This is how it is going to be formatted in the console to be displayed.
    {
        string goalString = $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";

        return goalString; // It returns a string with the correct format.
    }

}