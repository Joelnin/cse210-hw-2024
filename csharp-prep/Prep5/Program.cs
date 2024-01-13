using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); // Display wellcome message.
        string name = PromptUserName(); // Save user's name.
        int number = PromptUserNumber(); // Save user's number.
        int square = SquareNumber(number); // Square the user's number.
        DisplayResult(name, square); // Print info.
    }
    static void DisplayWelcome() // Welcome message.
    {
        Console.WriteLine("Welcome to the program!"); 
    }

    static string PromptUserName() // Ask for name and return the saved value.
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber() // Ask for number and return the saved value.
    {
        Console.Write("Please enter your favorite number: ");
        string userAnswer = Console.ReadLine();
        int userNumber = int.Parse(userAnswer);
        return userNumber;
    }

    static int SquareNumber(int number) // Square the number given.
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square) // Display info (name, number (square)).
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
 
}