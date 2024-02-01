using System;

public class BreatheingActivity : Activity // Activity class' child.
{
    public BreatheingActivity() : base ()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run() // The get the breathing activity running until completition.
    {
        DisplayStartingMessage(); // Display the welcome message.
        GetBreatheRounds(5); // First breathe is 5 seconds, this so the body can acomodate to next breathings. 
        
        int breathingTime = _duration; // Setting another variable to not change the original element and have how much time it takes to complete the activity.

        while (breathingTime != 0) // While the time remaining to complete the breathing activity is different from 0.
        {
            switch (breathingTime) // Using the breathing time as variable to decide.
            {
                case >= 10: // In case the time to complete the activity is 10 seconds or more, get the exercise going for 10 seconds.
                    GetBreatheRounds(10);
                    breathingTime -= 10; // Subtract 10 seconds from the remaining breathing time.
                    break;
                
                default: // In case the time to complete the activity is less than 10 seconds, get the exercise going for that many seconds.
                    GetBreatheRounds(breathingTime);
                    breathingTime = 0; // Set time remaining to 0 and end the exercise.
                    break;
            }
        }
        
        DisplayEndingMessage(); // Display ending message.
    }

    private void GetBreatheRounds(int seconds) // Get the timing for every set of breathing exercises.
    {
        int breatheingLeftover; // Setting a variable in case the seconds doesn't match 10's  distribution (in other words: seconds/10 != Whole number).

        if (seconds == 10) // In case the time is 10 seconds exact. 
        {
            breatheingLeftover = 10; // The time left is 10.
        }

        else // Seconds is other whole number appart from 10.
        {
            breatheingLeftover = seconds % 10; // Left time is the rest of the 10's distribution.
        }

        int breatheInTime; // Setting a variable for the breathe in exercise.

        if (breatheingLeftover < 4) // If the time remaining for the set of exercises is less than 4 seconds, not including 4.
        {
            breatheInTime = breatheingLeftover; // All the time goes for breathe in.
        }

        else if (breatheingLeftover >= 4 && breatheingLeftover < 6) // If the time remaining for the set of exercises is less than 6 seconds, not including 6, but equals to or is more than 4.
        {
            breatheInTime = 2; // Breathe in time is 2 seconds.
        }

        else // The time remaining for the set of exercises equals to or is more than 6 seconds.
        {
            breatheInTime = 4;  // Breathe in time is 4 seconds.
        }

        int breatheOutTime = breatheingLeftover - breatheInTime; // The rest of the remaining time is for the breathe out ecercise.

        Console.Write($"Breathe in... "); // Instruct to breathe in.
        ShowCountDown(breatheInTime); // Show the time remaining to do this exercise.

        Console.Write($"\nNow breathe out... "); // Instruct to breathe out.

        if (breatheOutTime > 0) // If there is still time to breathe out.
        {
            ShowCountDown(breatheOutTime); // Show the time remaining to do this exercise.
            Console.WriteLine(); // Line for aesthetic.
        }

        else // If there's no time to breathe out.
        {
            Console.WriteLine(); // Line for aesthetic.
            ShowSpinner(2); // They need time to breathe out, show a spinner to give 2 seconds to breathe out.
        }

        Console.WriteLine(); // Line for aesthetic.
    }

}