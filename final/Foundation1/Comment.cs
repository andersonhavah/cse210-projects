// This is the comment class for the YouTube Videos program

using System;

public class Comment{
    // Below are the member variables
    public string _name;
    public string _text;

    // This is the constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"    {_name}: {_text}");
    }
}