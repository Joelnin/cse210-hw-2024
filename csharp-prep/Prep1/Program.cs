using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your first name? "); // Ask for the first name.
        string firts_name = Console.ReadLine(); // Save the first name in "first_name".
        
        Console.Write("What is your last name? "); // Ask for last name.
        string last_name = Console.ReadLine(); // Save last name in "last_name".

        Console.WriteLine(); // Line for aesthetic.

        Console.WriteLine($"Your name is {last_name}, {firts_name} {last_name}."); // Print the info.

    }
}