using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string studentName1 = "Samuel Bennett";
        string topic1 = "Multiplication";

        // Assignment.
        Assignment assignment = new Assignment(studentName1, topic1);
        Console.WriteLine(assignment.GetSummary());

        // Math
        string textbookSection = "7.3";
        string problem = "8-19";
        MathAssignment mathAssignment = new MathAssignment(studentName1, topic1, textbookSection, problem);
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Writing
        string studentName2 = "Mary Waters";
        string topic2 = "European History";
        string title = "The Causes of World War II";
        WritingAssignment writingAssignment = new WritingAssignment(studentName2, topic2, title);
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}