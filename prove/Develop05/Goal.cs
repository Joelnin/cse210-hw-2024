using System;

public abstract class Goal
{
    protected string _shortName; // Name of the goal.
    protected string _description; // Short description of the Goal.
    protected int _points; // Points earned for reaching the Goal.

    public Goal(string name, string description, int points) // Basic constructor.
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName() // The name is needed for the  record. Getter needed.
    {
        return _shortName; // Return only the name of the Goal.
    }

    public abstract int RecordEvent(); // Rewards for doing the action.

    public abstract bool IsComplete(); // To know if the Goal has been reached.

    public abstract string GetStringRepresentation(); // This is how it is going to be formatted in the document to be saved later.

    public virtual string GetDetailsString() // This is how it is going to be formatted in the console to be displayed. The same for Eternal ans Simple but not Checklist.
    {
        string goalString = $"{_shortName} ({_description})";

        return goalString; // It returns a string with the correct format.
    }
}