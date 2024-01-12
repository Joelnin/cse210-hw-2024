using System;
using System.IO; 

public class Journal
{
    private List<Entry> _entries = new List<Entry>(); // A journal is a list of entries.

    // Note: A Journal is for:
    // > Writting new entries in.
    // > Read entries from. This can be from:
    // >> Current session.
    // >> Previous sessions. For this, the entries list must include any previous entry the user loads from external sources (this time it works only for .txt files with the right format) and it has to be added to the list in the correct format. 

    public void AddEntry(Entry newEntry) // Add a new entry in the journal and save it in the list of entriesfor further use.
    {
        newEntry.GetNewEntry(); // Create a new entry relaying on the user input.
        _entries.Add(newEntry); // Add this new entry to the list of entries collected in the session.
    }

    private void AddEntryFromFile(string date, string promptText, string entryText, string mood) // Add to the current journal an entry that already has information. This is for loading purposes.
    {
        Entry entry = new Entry();
        entry = entry.GetOldEntry(date, promptText, entryText, mood); // Organize the information obtained from the file.
        _entries.Add(entry); // Add this entry to the journal.
    }

    public void DisplayAll() // Display the journal (list of entries at the moment) on the terminal.  
    {
        List<Entry> entries = GetEntriesList(); // Get the journal.
        foreach (Entry entry in entries) // Loop in each and every element in the list.
        {
            entry.Display(); // Display each entry on the terminal.
        }

    }

    // Note: The journal can't be forever open on the terminal. So it should be:
    // > Saveable to a file.
    // > Loadable from a file.

    public void SaveToFile(string file) // Save the current journal to a .txt file (has to be specified the name and file extention).
    {
        List<Entry> entriesList = GetEntriesList(); // Get the current journal as a list.

        using (StreamWriter outputFile = new StreamWriter(file)) // Open a file to save.
        {
            foreach (Entry entry1 in entriesList) // Go through every entry in the journal.
            {
                string entry = entry1.SortEntryForRecord(); // Get each entry as a string line with the right format.
                outputFile.WriteLine(entry); // Write the line in the file and save it.
            }
        }

        // Message for aesthetic.
        Console.WriteLine($"\nSaving your journal in {file}... \nSaving successfull.");
    }

    public void LoadFromFile(string file) // Load a journal from a .txt file (has to be specified the name and file extention).
    {
        Console.WriteLine($"Loading your Journal from {file}..."); // Message for aesthetic.
        
        string[] lines = System.IO.File.ReadAllLines(file); // Open file, read each line (which are lineal entries), make a list of (lineal) entries.

        foreach (string line in lines) // Go through every line in the list of (lineal) entries.
        {
            string[] parts = line.Split(" //#// "); // Split the line in parts on every separator: " //#// ". 

            string date = parts[0]; // Part 1 = Index 0 = Date of the entry.
            string promptText = parts[1]; // Part 2 = Index 1 = Prompt of the entry.
            string entryText = parts[2]; // Part 3 = Index 2 = Text of the entry.
            string mood = parts[3]; // Part 4 = Index 3 = Mood/feelings.

            AddEntryFromFile(date, promptText, entryText, mood); // Adds the entry to the current journal.
        }
    }

    // Note: It is cleaner to get the info with functions.

    private List<Entry> GetEntriesList() // Get a list of Entries to use later.
    {
        List<Entry> entries = _entries; // Use the list in the current journal.

        return entries; // Return the list.
    }

}