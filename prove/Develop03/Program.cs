using System;

class Program
{
    static void Main(string[] args)
    {
        string file = "MPOldTestament.txt"; // File from where the scripture is being extracted.

        Library scriptureList = new Library(file); // Create a library with the file.
        Scripture scripture = scriptureList.GetRandomScripture(); // Select a random scripture from the library.
        
        Console.Clear(); // Clear the console for aesthetic. (It looks cleaner and prettier) 
        Console.WriteLine(scripture.GetDisplayText()); // Display the scripture showing all the words.
        string choice;

        do // Repeat the code until all the word are hidden or the user types "quit". Note: "Quit" is accepted thanks to .ToLower().
        {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish."); // Message for instructions.
            string input = Console.ReadLine(); // Read the input.
            choice = input.ToLower(); // Convert the input to lowercase.

            if (choice != "quit") // If the choice is different from "quit" hide 3 random words and display the text again.
            {
                scripture.HideRandomWords(3); // Hide 3 random words.
                Console.Clear(); // Clear the console.
                Console.WriteLine(scripture.GetDisplayText()); // Display the scripture with the hidden words.
            }

        } while (choice != "quit" && !scripture.IsCompletelyHidden()); // Loop end.

        if (scripture.IsCompletelyHidden()) // Display a message at the end depending on if they completed the scripture.
        {
            Console.WriteLine("\nGood job learning this one, hope to see you soon!");
        }

        else
        {
            Console.WriteLine("\nBye, hope to see you soon!");
        }
    }
/*
Shows creativity and exceeds core requirements:

I made a library for the scriptures. It can be made from any set that follow the rules:
Book //&// Chapter:Verse //#// ScriptureText
Book //&// Chapter:StartVerse-FinalVerse //#// ScriptureText

I create a file with some Old Testament ones so the program has something to use.
*/
}