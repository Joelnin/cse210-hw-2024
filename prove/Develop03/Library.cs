using System;
using System.IO;

public class Library
{
    private  List<Scripture> _listScriptures; // Each library is a list of scriptures.
    private string _file; // The file that contains it.

    public Library(string file) // A library that uses a name file to give a list of scriptures.
    {
        _file = file;
        _listScriptures = GetLibrary(_file); // Uses a getter to get the list for cleanliness.
    }

    private List<Scripture> GetLibrary(string file) // Getter for the library. Private to keep it encapsulated. Returns the list of scriptures.
    {
        List<Scripture> listScriptures = new List<Scripture>(); // Creating a list to save the scriptures.
        using (StreamReader reader = new StreamReader(file)) // File working station.
        {
            string line; // Create a line.
            while ((line = reader.ReadLine()) != null) // Read every line until there's an empty line.
            {
                string[] parts = line.Split(new string[] {" //#// "}, StringSplitOptions.None); // Broke every line in parts using " //#// " as separator.

                Reference reference = ReferenceFromFile(parts[0]); // Create a new reference, which corresponds to the first index in parts (parts[0]).
                string text = parts[1]; // The text is the second part (parts[1]).
                Scripture newScripture = new Scripture(reference, text); // Create a new object Scripture for organizing information.

                listScriptures.Add(newScripture); // Add the new scripture to the list of scriptures.
            }
        }

        return listScriptures; // Returns the list of scriptures.
    }

    // Note: The scripture displayed is going to be random.

    public Scripture GetRandomScripture() // To get a random scripture from the list.
    {
        Random random = new Random(); // Create a random chooser.
        int index = random.Next(_listScriptures.Count); // Using the index for choosing the scripture.
        Scripture scripture = _listScriptures[index]; // Selecting the scripture and saving it in a Scripture object.

        return scripture; // Returning the scripture.
    }

    private Reference ReferenceFromFile (string referenceString) // Reference from a string 
    {
        Reference reference;

        string[] parts1 = referenceString.Split(new string[] {" //&// "}, StringSplitOptions.None); // Broke the reference string into parts using " //&// " as a separator. 
        string book = parts1[0]; // First index is the book.

        string[] parts2 = parts1[1].Split(new string[] {":"}, StringSplitOptions.None); // Broke the string into parts using ":" as a separator. 
        int chapter = int.Parse(parts2[0]); // First index is the chapter.

        string[] parts3 = parts2[1].Split(new string[] {"-"}, StringSplitOptions.RemoveEmptyEntries); // Broke the string into parts using "-" as a separator. 
        int verse = int.Parse(parts3[0]); // First index is the first verse.

        if (parts3.Length > 1) // If there are more than one verse, then the second part is the end verse.
        {
            int endVerse = int.Parse(parts3[1]);
            reference = new Reference(book, chapter, verse, endVerse); // Create a various verse Reference object. 
        }

        else
        {
            reference = new Reference(book, chapter, verse); // Create a single verse Reference object.
        }

        return reference;
    }

}