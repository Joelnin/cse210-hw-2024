using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic) // Use studentName and topic from a constructor from the super class.
    {
        _title = title;
    }

    public string GetWritingInformation()  // Formatting the display of the writing homework.
    {
        string writingInfo = $"{_title} by {GetStudentName()}"; // This class doesn't have direct access but can use a getter for the student info.

        return writingInfo;
    }

}