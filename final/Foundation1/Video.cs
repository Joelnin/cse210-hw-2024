using System;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = comments;
    }

    public int CommentsCounter()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        int commentsCount = CommentsCounter();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{_title}");
        Console.ResetColor();
        Console.WriteLine($" [{_lengthSeconds} seconds]");

        Console.WriteLine($"By {_author}");
        Console.Write($"\nComments (");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{commentsCount}");
        Console.ResetColor();
        Console.WriteLine(")");


        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}