using System;

public class Assignment // Parent of assignments.
{
    private string _studentName; 
    private string _topic;


    public Assignment(string studentName, string topic) // An assignment has an student name and a topic.
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary() // Get the assignment info in a specific format.
    {
        string summary = $"{_studentName} - {_topic}";
        
        return summary;
    }

    public string GetStudentName() // Get the student's value to use outside.
    {
        return _studentName;
    }

    





















}