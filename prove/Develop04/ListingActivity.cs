using System;

public class ListingActivity : Activity // Activity's child.
{
    private int _count;
    // Make a list of prompts so one can be picked, this list can't be modified by the user.
    private List<string> _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
    };

    public ListingActivity() : base ()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run() // The get the listing activity running until completition.
    {
        DisplayStartingMessage(); // Display the welcome message.
        GetRandomPrompt(); // Get a random prompt to make list about.

        List<string> userResponses = GetListFromUser(); // Get a list from every item the user inputs.
        _count = userResponses.Count; // Get the number of items.

        Console.WriteLine($"You listed {_count} items!\n"); // Inform about the length of the list.

        DisplayEndingMessage(); // Display ending message.
    }

    public void GetRandomPrompt() // Get a random propmt to think and list items about.
    {
        Random random = new Random(); // Create a random chooser.
        int index = random.Next(_prompts.Count); // Using the index for choosing the prompt.
        string prompt = _prompts[index]; // Selecting the prompt and saving it.
        string output = $"List as many responses you can to the following prompt: \n --- {prompt} ---"; // Formatting the output.

        Console.WriteLine(output); // Display the prompt.
    }

    public List<string> GetListFromUser() // Get a list out of the input from the user.
    {
        List<string> userResponses = new List<string>(); // Create a new list for the inputs.

        Console.Write("You may begin in: "); // Getting the user ready.
        ShowCountDown(5); // Giving 5 seconds to be prepared.
        Console.WriteLine(); // Line for aesthetic.

        DateTime startTime = DateTime.Now; // Variable for starting time of the exercise.
        DateTime futureTime = startTime.AddSeconds(_duration); // Variable for ending time of the exercise.
        DateTime currentTime = DateTime.Now; // Variable for actual time during the exercise.

        while (currentTime < futureTime) // Continue the exercise as long as the actual time is less than the ending time.
        {
            Console.Write("> "); // Tell the user where to write.
            userResponses.Add(Console.ReadLine()); // Add the response to the list.
            currentTime = DateTime.Now; // Update actual time variable.
        }

        return userResponses; // Return the list of responses.
    }

}