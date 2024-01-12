using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // Create a Journal.
        Console.WriteLine("Welcome to the Journal Program!"); // Welcome message.
        string choice; // Variable to choose from the different options to go: choice.

        do // Prompt the user to make a decision based on the following options.
        {
            choice = GetChoice(); // Display options.

            switch (choice) // Using the switch to visualize the options in an easier way.
            {
                // In case of choosing option "X", do choice "X". Note: Choices are static functions.
                case "1": 
                    Choice1(journal);
                    break;

                case "2":
                    Choice2(journal);
                    break;

                case "3":
                    Choice3(journal);
                    break;

                case "4":
                    Choice4(journal);
                    break;
                
                case "5":
                    Choice5();
                    break;

                default:
                    Console.WriteLine("That's not a valid option."); // In case the user input doesn't satisfy the options, display a message to prompt the user for a valid option.
                    break;
            }
        } while (choice != "5"); // Stop if they input "5" (Quit).

        // Note: it's easier to visualize the options as functions: 
        // > Get the choice to know what the user want to do.
        // 1. Write a new entry
        // 2. Display de current journal.
        // 3. Load a journal from a .txt file.
        // 4. Save the current journal to a .txt file.
        // 5. End session.

        static string GetChoice() // Display the options between the program, save the user's choice.
        {
            Console.WriteLine("\nPlease, select one of the following choices:"); // Explanatory message.
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit"); // Options.
            Console.Write("What would you like to do? "); // Prompting.

            string choice = Console.ReadLine(); // Saving user's input.

            return choice; // Return the choice to use on the program.
        }

        static void Choice1(Journal journal) // Add a new entry to the current journal.
        {
            Entry newEntry = new Entry(); // Create a new entry.
            journal.AddEntry(newEntry); // Introduce new info into the entry and save.
        }

        static void Choice2(Journal journal) // Display the current journal on the terminal.
        {
            journal.DisplayAll(); // Display the current journal.
        }

        static void Choice3 (Journal journal) // Load the journal from a .txt file (specified by the user). 
        {
            Console.WriteLine("Please, enter the filename to load the Journal from: "); // Prompting for the file name and extention.
            string file = Console.ReadLine(); // Save the file name.
            journal.LoadFromFile(file); // Load journal.
        }

        static void Choice4(Journal journal) // Save the current journal to a .txt file (specified by the user).
        {
            Console.WriteLine("Please, enter a filename to save (remember to add .txt at the end of the filename): "); // Prompting for the file name and extention.
            string file = Console.ReadLine(); // Save the file name.
            journal.SaveToFile(file); // Load journal.
        }

        static void Choice5() // End the current session.
        {
            Console.WriteLine("Bye, see you later!"); // Goodbye message.
        }

    }

}