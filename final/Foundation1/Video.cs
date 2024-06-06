// This is the video class for the YouTube Videos program

using System;
using System.Collections.Generic;

public class Video {
    // Below are the attributes or member variables of the Video class
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    // This is the constructor of the Video class
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // This method returns the number of comments made on a video
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // This method adds a comment to the list of Comments
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // This method displays the information about the video
     public void DisplayInfo()
    {
        Console.WriteLine($"Title of the video: {_title}");
        Console.WriteLine($"Author of the video: {_author}");
        Console.WriteLine($"Length of the video: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}

