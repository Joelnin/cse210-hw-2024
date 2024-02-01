using System;

public class PhysicalActivity : Activity // Activity class' child.
{
    private List<string> _sections = new List<string> {
            "Lower region",
            "Upper region"
    };
    public PhysicalActivity() : base ()
    {
        _name = "Physical";
        _description = "This activity will help you relax by walking your through actions for progressive muscle relaxation. You should focus on gently contracting and then relaxing your muscles.";
    }

    public void Run() // The get the exercise activity running until completition.
    {
        DisplayStartingMessage(); // Display welcome message.
        DisplayExercise(); // Display exercise set.

        int exerciseTime = _duration; // Setting another variable to not change the original element and have how much time it takes to complete the activity.

        while (exerciseTime != 0) // While the time remaining to complete the physical activity is different from 0.
        {
            switch (exerciseTime) // Using the exercise time as variable to decide.
            {
                case >= 14: // In case the time to complete the activity is 14 seconds or more, get the exercise going for 14 seconds.
                    GetExerciseRoundsTimer(14);
                    exerciseTime -= 14; // Subtract 14 seconds from the remaining exercise time.
                    break;
                
                default: // In case the time to complete the activity is less than 14 seconds, get the exercise going for that many seconds.
                    GetExerciseRoundsTimer(exerciseTime);
                    exerciseTime = 0; // Set time remaining to 0 and end the exercise.
                    break;
            }
        }

        DisplayEndingMessage(); // Display ending message.
    }

    private void DisplayExercise() // Display the exercise in a specific format.
    {
        Console.WriteLine("Which part would you like to relax? "); // Explanation.

        string lowerExercise = "Flex your feet and toes. Tense your thighs, calves and glutes"; // Description of lower body parts exercise.
        string upperExercise = "Close your fists. Tighten your forearms, biceps and pecs"; // Description of upper body parts exercise.
        int choice; // Variable to get the choice.

        do // Continue while the user doesn't pick a valid option.
        {
            Console.WriteLine("1. Lower region \n2. Upper region"); // Options.
            Console.Write("Select a choice from the menu: "); // Prompting.
            choice = int.Parse(Console.ReadLine()); // Saving user's input.
            Console.Clear(); // Cleaning for aesthetic.

            switch (choice) // Using "choice" to decide.
            {
                case 1: // Lower region
                    DisplayExercise(_sections[0], lowerExercise);
                    break;

                case 2: // Upper region
                    DisplayExercise(_sections[1], upperExercise);
                    break;
                
                default: // In case the user input doesn't satisfy the options, display a message to prompt the user for a valid option.
                    Console.WriteLine("That's not a valid option.");
                    break;
            }
        } while (choice != 1 && choice != 2);

    }

    private void GetExerciseRoundsTimer(int seconds) // Get the timing for every set of exercises.
    {
        int ExercisingLeftover; // Setting a variable in case the seconds doesn't match 14's  distribution (in other words: seconds/14 != Whole number).

        if (seconds == 14) // In case the time is 14 seconds exact. 
        {
            ExercisingLeftover = 14; // The time left is 14.
        }

        else // Seconds is other whole number appart from 14.
        {
            ExercisingLeftover = seconds % 14; // Left time is the rest of the 14's distribution.
        }

        int ExerciseInTime; // Setting a variable for the Hold exercise.

        if (ExercisingLeftover <= 4) // If the time remaining for the set of exercises is less than or equal to 4 seconds.
        {
            ExerciseInTime = ExercisingLeftover; // All the time goes for hold.
        }

        else if(ExercisingLeftover <= 10 && ExercisingLeftover > 4) // If the time remaining for the set of exercises is less than or equal to 10 seconds, but is more than 4, not including 4.
        {
            ExerciseInTime = 5; // Hold time is 5 seconds.
        }

        else // If the time remaining for the set of exercises is less than 14 seconds, not including, but equals to or is more than 4.
        {
            ExerciseInTime = 7; // Hold time is 6 seconds.
        }

        int ExerciseOutTime = ExercisingLeftover - ExerciseInTime; // The rest of the remaining time is for the exercise end.

        Console.Write("Hold on tight... "); // Instruct to Hold.
        ShowCountDown(ExerciseInTime); // Show the time remaining to do this exercise.

        Console.Write($"\nNow let go, shaking your limbs should help... "); // Instruct to let go.

        if (ExerciseOutTime > 0) // If there is still time to let go.
        {
            ShowCountDown(ExerciseOutTime); // Show the time remaining to do this exercise.
            Console.WriteLine(); // Line for aesthetic.
        }

        else // If there's no time to let go.
        {
            Console.WriteLine(); // Line for aesthetic.
            ShowSpinner(3); // They need time to let go, show a spinner to give 3 seconds to let go.
        }

        Console.WriteLine(); // Line for aesthetic.
    }

    private void DisplayExercise(string section, string exercise) // Display the exercise set in a specific format.
    {
        Console.WriteLine($"To relax your {section}, you'll need to: \n > {exercise}."); // Explain the exercise.
        ShowSpinner(5); // Time to read what the exercise is about.
        Console.Write("\nGet ready..."); // Warning that the timer for the exercise is going to start.
        ShowCountDown(3); // Time to get ready for the exercise.
        Console.WriteLine("\n"); // Empty line for aesthetic.
    }

}