using System;

public class ReflectingActivity : Activity
{
    // Make a list of prompts so one can be picked, this list can't be modified by the user.
    private List<string> _prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
    };
    // Make a list of questions so one can be picked, this list can't be modified by the user.
    private List<string> _questions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base ()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run() // The get the reflecting activity running until completition.
    {
        DisplayStartingMessage(); // Display the welcome message.
        DisplayPrompt(); // Get a random prompt to make list about.

        Console.WriteLine("When you have something in mind, press enter to continue."); // Instruct the user to think and then press enter.
        Console.ReadLine(); // Wait for the enter.
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience:"); // Tell the user to think about the next questions.
        Console.Write("You may begin in: "); // Getting the user ready.
        ShowCountDown(5); // Giving 5 seconds to be prepared.
        Console.Clear(); // Cleaning the console for aesthetic.

        int ponderTime = _duration;  // Setting another variable to not change the original element and have how much time it takes to complete the activity.

        DateTime startTime = DateTime.Now; // Variable for starting time of the exercise.
        DateTime futureTime = startTime.AddSeconds(ponderTime); // Variable for ending time of the exercise.
        DateTime currentTime = DateTime.Now; // Variable for actual time during the exercise.

        while (currentTime < futureTime) // Continue the exercise as long as the actual time is less than the ending time.
        {
            switch (ponderTime) // Using the ponder time as variable to decide.
            {
                case >= 15: // In case the time to complete the activity is 15 seconds or more, get the spinner animation going for 15 seconds.
                    DisplayQuestion(15);
                    ponderTime -= 15; // Subtract 15 seconds from the remaining ponder time.
                    break;
                
                default: // In case the time to complete the activity is less than 15 seconds, get the spinner animation going for that many seconds.
                    DisplayQuestion(ponderTime);
                    ponderTime = 0; // Set time remaining to 0 and end the exercise.
                    break;
            }

            currentTime = DateTime.Now; // Update actual time variable.
        }

        Console.WriteLine();  // Line for aesthetic.
        DisplayEndingMessage(); // Display ending message.
    }

    public string GetRandomPrompt()  // Get a random propmt to think about.
    {
        Random random = new Random(); // Create a random chooser.
        int index = random.Next(_prompts.Count); // Using the index for choosing the prompt.
        string prompt = _prompts[index]; // Selecting the prompt and saving it.

        return prompt; // Returning the prompt.
    }
    
    public string GetRandomQuestion() // Get a random propmt to think about.
    {
        Random random = new Random(); // Create a random chooser.
        int index = random.Next(_questions.Count); // Using the index for choosing the question.
        string question = _questions[index]; // Selecting the question and saving it.

        return question; // Returning the question.
    }

    public void DisplayPrompt()  // Formartting how the prompt is going to be displayed.
    {
        string format = $"Consider the following prompt: \n\n --- {GetRandomPrompt()} ---\n"; // Format for displaying the prompt.

        Console.WriteLine(format); // Display the prompt.
    }

    public void DisplayQuestion(int seconds)
    {
        Console.Write($"> {GetRandomQuestion()} "); // Format for displaying the question.
        ShowSpinner(seconds); // Animation of spinner for the seconds needed to ponder each question.
        Console.WriteLine(); // Empty line for aesthetic.
    }

}