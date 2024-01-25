using System;

public class Reference
{
    // A reference has:
    private string _book; // The book where it's found.
    private int _chapter; // The chapter.
    private int _verse; // First verse, the verse in which the scripture starts.
    private int _endVerse; // Last verse, the verse in which the scripture finishes.

    // Note: The reference can be:
    // > Just a verse.
    // > Multiple verses.

    public Reference(string book, int chapter, int verse) // Reference for a single verse.
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }    
    
    public Reference(string book, int chapter, int startVerse, int endVerse) // Reference for multiple consecutive verses.
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string DisplayReference() // Formatting the reference to be a string so it can be used for display later.
    {
        string stringReference; // It needs a variable to return the string.

        if (_endVerse == 0) // In case the scripture is a single verse.
        {
            stringReference = $"{_book} {_chapter}:{_verse}"; // Use the format: Book Chapter:Verse (e.g., Genesis 2:24)
        }

        else // Otherwise, it contains multiple verses. 
        {
            stringReference = $"{_book} {_chapter}:{_verse}-{_endVerse}"; // Use the format: Book Chapter:First Verse-Last Verse (e.g., Abraham 3:22-23)
        }

        return stringReference; // Return the reference as a string so it can be diplayed.
    }

}