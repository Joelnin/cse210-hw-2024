using System;
using System.Linq;

public class Scripture
{
    private Reference _reference; // Reference to where the scripture is from.
    private List<Word> _words; // A list of words that are the scripture, the verse(s).

    public Scripture(Reference reference, string text) // The scripture must receive a reference and a text from outside.
    {
        _reference = reference; // The reference is handle on another class.
        _words = text.Split(" ").Select(word => new Word(word)).ToList(); // The text of the scripture is broken into parts, setting blank spaces ( ) as the separators. Every resulting item is a new object Word (called word) and gets added to the list of words for the scripture.
    }

    // Note: The scripture must:
    // > Format the scripture as a string to display.
    // > Hide words at random.
    // > Check if there is any other word to hide.

    public bool IsCompletelyHidden() // Check if there is no more words being shown.
    {
        return _words.All(word => word.IsHidden()); // Return "true" if every word in the list of words is hidden. If at least one is not hidden, returns "false".
    }

    public void HideRandomWords(int numbersToHide) // Hide words at random.
    {
        Random random = new Random(); // Create a new object to get a random number.

        for (int i = 0; i < numbersToHide ; i++) // Repeat the code inside as many times a numbersToHide.
        {
            Word word; // Create a Word to work later.

            do // Keep chossing another word to hide at random if the choosen word is hidden.
            {
                word = _words[random.Next(_words.Count)];

            } while (word.IsHidden());

            word.Hide(); // Hide the word.

            if (IsCompletelyHidden()) // Stop the loop if everyword is hidden.
            {
                break;
            }
        }
    }

    public string GetDisplayText() // Store the format and return a formatted string.
    {
        string paragraph = String.Join(" ", _words.Select(word => word.GetDisplayText())); // Make a paragraph out of a list of words.

        string scripture = $"{_reference.DisplayReference()} \n{paragraph}"; // Format the scripture display.

        return scripture; // Return the formatted string.
    }

}