using System;

public class Menu
{
    public void Start()
    {
        string choice; // Variable to choose from the different options to go: choice.

        do // Prompt the user to make a decision based on the following options.
        {
            Console.Clear();
            choice = GetChoice(); // Display options.

            switch (choice) // Using the switch to visualize the options in an easier way.
            {
                case "1": // Start breathing activity.
                    BreatheingActivityChoice();
                    break;

                case "2": // Start reflecting activity.
                    ReflectingActivityChoice();
                    break;

                case "3": // Start listing activity.
                    ListingActivityChoice();
                    break;

                case "4": // Start physical activity.
                    PhysicalActivityChoice();
                    break;
                
                case "5": // End session.
                    ChoiceQuit();
                    break;

                default:
                    Console.WriteLine("That's not a valid option."); // In case the user input doesn't satisfy the options, display a message to prompt the user for a valid option.
                    break;
            }

        } while (choice != "5"); // Stop if they input "5" (Quit).
    }

    private string GetChoice() // Display the options between the program, save the user's choice.
    {
        Console.WriteLine("Menu Options:"); // Explanatory message.
        Console.WriteLine("1. Start breathing activity \n2. Start reflecting activity \n3. Start listing activity \n4. Start physical activity \n5. Quit"); // Options.
        Console.Write("Select a choice from the menu: "); // Prompting.

        string choice = Console.ReadLine(); // Saving user's input.

        return choice; // Return the choice to use on the program.
    }

    private void BreatheingActivityChoice() // Start breathing activity.
    {
        BreatheingActivity breatheingActivity = new BreatheingActivity();
        breatheingActivity.Run();
    }

    private void ReflectingActivityChoice() // Start reflecting activity.
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.Run();
    }

    private void ListingActivityChoice() // Start listing activity.
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.Run();
    }

    private void PhysicalActivityChoice() // Start physical activity.
    {
        PhysicalActivity physicalActivity = new PhysicalActivity();
        physicalActivity.Run();
    }

    private void ChoiceQuit() // End the current session.
    {
        Console.WriteLine("Bye, see you later!"); // Goodbye message.
    }

}