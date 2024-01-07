using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your first name? "); // Ask for the first name.
        string firtsName = Console.ReadLine(); // Save the first name in "firstName".
        
        Console.Write("What is your last name? "); // Ask for last name.
        string lastName = Console.ReadLine(); // Save last name in "lastName".

        Console.WriteLine(); // Line for aesthetic.

        Console.WriteLine($"Your name is {lastName}, {firtsName} {lastName}."); // Print the info.

    }
}