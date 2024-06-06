using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create Videos
        Video video1 = new Video("Life in Togo", "John Samuel", 600);
        Video video2 = new Video("Abstraction in Java", "Samantha Anderson", 1200);
        Video video3 = new Video("Intro to Programming With Python", "Jameson Matthew", 300);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "The foods look delicious."));
        video1.AddComment(new Comment("Jack", "I want to come visit Togo after watching your video."));
        video1.AddComment(new Comment("Kane", "What kind of dance is that? I am looking forward to bouncing my body on it in Togo."));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "Loved the abstraction explanation."));
        video2.AddComment(new Comment("James", "Instructional video! Right to the point! I enjoyed it!"));
        video2.AddComment(new Comment("Immanuel", "I love Java! I enjoyed learning this OOP concept with you!"));

        // Add comments to video3
        video3.AddComment(new Comment("Michael", "Good introduction."));
        video3.AddComment(new Comment("Janet", "Nice examples."));
        video3.AddComment(new Comment("Daniel", "Easy to follow."));

        // Below is the list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        Console.WriteLine("");
        // Display each video information
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}