using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? "); // Ask for percentage.
        string userInput = Console.ReadLine(); // Percentage in a str: UserInput.
        float percentage = float.Parse(userInput); // Percentage in a float: percentage.
        string letter; // Variable for grade letter: letter.
        string decisionMessage; // Variable for failing/failing class message: decisionMessage.

        // If's statements for deciding wich letter to use.
        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }

        else if (percentage >= 70)
        {
            letter = "C";
        }

        else if (percentage >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        // If's statements for deciding if the kid passed the class. (Hope they do)

        if (percentage >= 70)
        {
            decisionMessage = "Congratulations, you passed!";

        }

        else
        {
            decisionMessage = "Sorry, you haven't passed the course this time. \nNext time will be better, don't give up!";
        }

        Console.WriteLine($"Your grade is: {letter}");
        Console.WriteLine($"{decisionMessage}");

    }
}