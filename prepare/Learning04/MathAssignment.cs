using System;

public class MathAssignment : Assignment // Sub of the Assignment class.
{
    private string _textbookSection;
    private string _problem; 

    public MathAssignment(string studentName, string topic, string textbookSection, string problem) : base(studentName, topic) // Use studentName and topic from a constructor from the super class.
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

    public string GetHomeworkList() // Formatting the display of the math homework.
    {
        string homeworkList = $"Section {_textbookSection} Problems {_problem}";

        return homeworkList;
    }

}