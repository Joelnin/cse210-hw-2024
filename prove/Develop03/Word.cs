using System;

public class Word
{
    private string _text; // The word comes in the form of text, so it will be called _text.
    private bool _isHidden; // There needs to be an indicator that the word has already been hidden.

    public Word(string text) // Take a word in a form of a string.
    {
        _text = text; // The word is the text to work with.
        _isHidden = false; // Boolean value on "false" as default for which mean the word "is not hidden" as a default.
    }

    // Note: A word has to be capable of:
    // > Hide a word.
    // > Show the word.
    // > Check if the word id already hidden.
    // > Display the word in a specific format.

    public void Hide() // To hide the word.
    {
        List<string> characters = GetLettersInWord(); // Get every character in the word as a list of strings.
        List<string> letters = new List<string>(); // Create a new list of string to almacenate the changed letters.

        foreach (string character in characters) // For each item (character) in the list of characters.
        {
            string letter = character.Replace(character, "_"); // Replace it with an underscore (_).
            letters.Add(letter); // Add it to the list of letters.
        }

        _text = String.Join("", letters); // Make a string out of the underscores. And make it the new text.
    }

    public void Show() // To show a word.
    {
        List<string> letters = GetLettersInWord(); // Get every character in the word as a list of strings.

        _text = String.Join("", letters); // Make a string out of the letters and make it the new text.
    }

    public bool IsHidden() // To check if the word is already hidden.
    {
        List<string> letters = GetLettersInWord(); // Get every character in the word as a list of strings.

        if (letters[0] == "_") // Because every hidden word is a string of underscores (_), if the first letter is an underscore, then it must be a hidden word.
        {
            _isHidden = true; // Change the value to "true".
        }

        else // Otherwise, it is not a hidden word.
        {
            _isHidden = false; // The value keeps being "false".
        }

        return _isHidden; // Return the verdict for the word (Is it hidden or not?).
    }

    public string GetDisplayText() // Get the text as a string for later used. Note: this is a getter.
    {
        return _text;    
    }

    private List<string> GetLettersInWord() // Helper to get the characters in a word returning them a list of string.
    {
        List<string> letters = new(); // New list to save the letters.
        
        

        foreach (char character in _text) // Go through every character in the text, converting it in a char variable.
        {
            string letter = new string(character, 1); // New variable to convert the char into string. This returns the character as a string a single time, turning it into a letter.
            letters.Add(letter); // Add the letter to the letters list.
        }

        return letters; // Return a list which each item is a letter in a word.
    }

}