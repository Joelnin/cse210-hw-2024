using System;

public class GamingAnimation
{
    private int _seconds; // Seconds the animations is going to run.

    public GamingAnimation()
    {
        _seconds = 0; // Set as 0 from default.
    }

    public void Spinner(int seconds)  // Animation of spinner.
    {
        _seconds = seconds; // Setting the time.
        List<string> spinnerAnimation = new List<string> { // Making a list of the 4 elements to make the spinner.
            "|",
            "/",
            "-",
            "\\",
        };

        DateTime startTime = DateTime.Now; // Setting the starting time for the animation.
        DateTime endTime = startTime.AddSeconds(_seconds); // Setting the ending time for the animation.

        int i = 0; // Variable for the spinnerAnimation list's index.

        while (DateTime.Now < endTime) // Go through the list spinnerAnimation, write each item, stopping for a 0.35 seconds with each, until getting to the ending time.
        {
            string s = spinnerAnimation[i]; // Get the item as a string.
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

    public void ChargingDots(int seconds)  // Animation of 3 dots.
    {
        _seconds = seconds;
        int sleepTime = 333; // Needs to be 1/3 of second, but needs to be an integer, so its 0.333 seconds.

        List<string> dotAnimation = new List<string> { // Making a list of the 3 elements to make the dots.
            ".",
            ".",
            "."
        };

        DateTime startTime = DateTime.Now; // Setting the starting time for the animation.
        DateTime endTime = startTime.AddSeconds(_seconds); // Setting the ending time for the animation.

        int i = 0; // Variable for the dotAnimation list's index.

        while (DateTime.Now < endTime) // Go through the list dotAnimation, write each item, stopping for 0.333 seconds with each, until getting to the ending time.
        {
            string d = dotAnimation[i]; // Get the item as a string.
            Console.Write(d); // Write the item.
            Thread.Sleep(sleepTime); // Stop for 0.333 seconds.
            i++; // Add 1 to the index to get the next item.

            if (i >= dotAnimation.Count) // If the count gets to the last item, go back to 0 and start the items list again.
            {
                i = 0;
                Console.Write("\b\b\b   \b\b\b"); // Erase the item.
                Thread.Sleep(sleepTime); // If there's anything time left, let the user see the animation of empty for closure.
            }
        }
    }

    public void ChargingBar(int seconds)  // Animation of a charging bar.
    {
        _seconds = seconds;
        int sleepTime = _seconds * 100; // 

        List<string> barAnimation = new List<string> { // Making a list of the elements to make the bars.
            "          ",
            "|         ",
            "||        ",
            "|||       ",
            "||||      ",
            "|||||     ",
            "||||||    ",
            "|||||||   ",
            "||||||||  ",
            "||||||||| ",
            "||||||||||",
            " Complete ",
        };

        DateTime startTime = DateTime.Now; // Setting the starting time for the animation.
        DateTime endTime = startTime.AddSeconds(_seconds * 1.2); // Setting the ending time for the animation.

        int i = 0; // Variable for the barAnimation list's index.

        while (DateTime.Now < endTime) // Go through the list barAnimation, write each item, stopping for a 0.35 seconds with each, until getting to the ending time.
        {
            string b = barAnimation[i]; // Get the item as a string.
            Console.Write("I"); // Left side of the bar.
            Console.ForegroundColor = ConsoleColor.Green; // Make the color of the bars green.
            Console.Write($"{b}"); // Display the item.
            Console.ResetColor(); // Change the color back to system's default.
            Console.Write("I"); // Right side of the bar.
            Thread.Sleep(sleepTime); // Stop for 0.35 seconds.
            i++; // Add 1 to the index to get the next item.
            
            EraseLine(); // Delete line for the next part of the animation.
        }
    }

    public void ColorfulMessage(string message) // Animation to change the color of a message 4 times.
    {
        List<string> congratsAnimation = new List<string>(); // Create a new list

        do // Make a list of 4 elements with the message.
        {
            congratsAnimation.Add(message);

        } while (congratsAnimation.Count != 4);


        for (int i = 0; i < congratsAnimation.Count; i++) // For the items in the list.
        {
            string c = congratsAnimation[i]; // Get the item as a string.

            if (i == 0) // For the first item. Display it in green.
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            else if (i == 1) // Display second item in blue.
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }

            else if (i == 2) // Display third item in yellow.
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            else // Display fourth item in pink.
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }

            Console.Write($"{c}"); // Display the message in the color.
            Thread.Sleep(300); // Stop for 0.3 seconds.
            EraseLine(); // Erase the line for next display.
        }

        Console.ResetColor(); // Change the color back to system's default.
        Console.Write(message); // Display the message with default colors.
    }

    private void EraseLine() // Private function to erase a line in the console.
    {
        int cursorTop = Console.CursorTop; // Get the cursor position.
        Console.SetCursorPosition(0, cursorTop); // Position the cursor in the begining of the line in the console.
        Console.Write(new string(' ', Console.WindowWidth)); // Erase the line, setting blanckspaces.
        Console.SetCursorPosition(0, cursorTop);  // Position the cursor in the begining of the line in the console again.
    }

}