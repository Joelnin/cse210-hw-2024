using System;

public class Entry
{
    private string _date; // Every entry needs to have a date.
    private string _promptText; // The question.
    private string _entryText; // And the answer to that question.
    private string _mood; // This is for keeping track of mood swings and look for patterns with the answers.

    // Note: An entry can have info from a source (e.g, be an old entry on a file) or can be a new one:
    // > New entries need to get every item anew, depends on the user and new written info.
    // > Old entries need their items to be sorted so they can be used, the info has to be read.

    public Entry GetNewEntry() // Generate a new entry with no prior information.
    {
        Entry entry = new Entry(); // Create an entry object.
        entry._date = GetDate(); // Get the date for this new entry.
        entry._mood = GetMood(); // Save the mood of typed.
        entry._promptText = GetPrompt(); // Get a new prompt for this new entry.
        entry._entryText = GetEntryText(); // Save what the user types.


        return entry; // Return an entry.
    }

    public Entry GetOldEntry(string date, string promptText, string entryText, string mood) // Generate a new entry with prior information. This is for organizing that info.
    {
        Entry entry = new Entry(); // Create an entry object.
        entry._date = date; // Get the date of the entry.
        entry._promptText = promptText; // Get the prompt of the entry.
        entry._entryText = entryText; // Get what the user typed.
        entry._mood = mood; // Get the mood of the entry.

        return entry; // Return an entry
    }

    // Note: The entries need formatting. 
    // > If they are going to be displayed
    // > To save them.

    public void Display() // Display the entry on the terminal with a specific format.
    {
        Console.WriteLine($"Date: {_date} - Mood/feelings: {_mood} \nPrompt: {_promptText} \n{_entryText} \n");
    }

    public string SortEntryForRecord() // Sort an entry so it can be filed or saved in a specific format for later use.
    {
        string entry = $"{_date} //#// {_promptText} //#// {_entryText} //#// {_mood}";

        return entry;
    }

    // Note: It is easier to get the info for new entries with functions. An Entry needs:
    // > Date.
    // > Prompt.
    // > Entry text.
    // > Mood.

    private string GetDate() // Get the date as a string and with a specific format.
    {
        DateTime theCurrentTime = DateTime.Now; // Create a new object for the date according to the user system.
        _date = theCurrentTime.ToString("MM/dd/yyyy"); // Save the date as a string with a specific format.

        return _date; // Return the date for the Entry to use and save it.
    }

    private string GetPrompt() // Get a random prompt and display this prompt in the terminal.
    {
        PromptGenerator promptText = new PromptGenerator(); // Create a random-prompt-generator.
        _promptText = promptText.GetRandomPrompt(); // Get a prompt and save it.
        Console.WriteLine(_promptText); // Display the prompt in the terminal so it can be visible.

        return _promptText; // Return the prompt for the Entry to use and save.
    }

    private string GetEntryText() // Get the input from the user so it can be saved for later use.
    {
        Console.Write("> "); // It's pretty to indicate where to write.
        _entryText = Console.ReadLine(); // Save the user input, this is the crucial part of the Entry.

        return _entryText; // Return the entry for the Entry to use and save.
    }

    private string GetMood() // Get the mood from the user so it can be saved for later use.    
    {
        Console.Write("How are you feeling? "); // Prompt the user to say their mood.
        _mood = Console.ReadLine(); // Save the user input, this is the final part of the Entry.

        return _mood; // Return the mood for the Entry to use and save.
    }

}