using System;

public class Comment
{
    private string _name;
    private string _content;

    public Comment (string name, string content)
    {
        _name = name;
        _content = content;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: \n{_content}");
    }
}