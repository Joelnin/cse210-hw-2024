using System;

public class Activity
{
    protected string _name; // Activity name.
    protected string _description; // Type of activity.
    protected int _duration; // Timer in seconds.

    public Activity()
    {
        _name = "Activity";
        _description = "This activity is healthy";
        _duration = 30;
    }

    public void DisplayStartingMessage() // Formartting how the start message is going to be displayed.
    {
        Console.Clear(); // Clean the console.
        Console.WriteLine($"Welcome to {_name} Activity.\n"); // Welcome message to corresponding activity.
        Console.WriteLine($"{_description}\n"); // Explaining activity's goal.
        Console.Write("How long, in seconds, would you like for your session? "); // Prompting for seconds to do the activity.
        _duration = int.Parse(Console.ReadLine()); // Save it on "_duration".
        Console.Clear(); // Clean the console.
        Console.WriteLine("Get ready..."); // Message to be ready.
        ShowSpinner(5); // Animation of spinner for 5 seconds.
        Console.WriteLine(); // Empty line for aesthetic.
    }

    public void DisplayEndingMessage() // Formartting how the end message is going to be displayed.
    {
        Console.WriteLine("Well done!!"); // Message to congratulate.
        ShowSpinner(5); // Animation of spinner for 5 seconds.
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity."); // Displaying information of the completiong of the activity.
        ShowSpinner(5); // Animation of spinner for 5 seconds.
    }

    public void ShowSpinner(int seconds)  // Animation of spinner.
    {
        List<string> spinnerAnimation = new List<string> { // Making a list of the 4 elements to make the spinner.
            "|",
            "/",
            "-",
            "\\",
        };

        DateTime startTime = DateTime.Now; // Setting the starting time for the animation.
        DateTime endTime = startTime.AddSeconds(seconds); // Setting the ending time for the animation.

        int i = 0; // Variable for the spinnerAnimation list's index.

        while (DateTime.Now < endTime) // Go through the list spinnerAnimation, write each item, stopping for a 0.35 seconds with each, until getting to the ending time.
        {
            string s = spinnerAnimation [i]; // Get the item as a string.
            Console.Write(s); // Write the item.
            Thread.Sleep(350); // Stop for 0.35 seconds.
            Console.Write("\b \b"); // Erase the item.

            i++; // Add 1 to the index to get the next item.

            if (i >= spinnerAnimation.Count) // If the count gets to the last item, go back to 0 and start the items list again.
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds) // Animation of count down.
    {
        for (int i = seconds; i > 0; i--) // For every positive second, reproduce and subtract a second.
        {
            Console.Write($"{i}"); // Print the second in numbers.
            Thread.Sleep(1000); // Stop for 1 second.
            Console.Write("\b \b"); // Erase the number.
        }
    }

}