using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Introduction to C# Classes", "Programming with Mosh", 720);
        Video video2 = new Video("Abstraction in Object-Oriented Programming", "freeCodeCamp", 945);
        Video video3 = new Video("How to Build a YouTube Clone", "Traversy Media", 1850);
        Video video4 = new Video("C# for Beginners - Full Course", "Amigoscode", 3600);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "This really helped me understand classes!"));
        video1.AddComment(new Comment("Bob", "Clear explanations, thank you."));
        video1.AddComment(new Comment("Charlie", "When is the next video coming out?"));
        video1.AddComment(new Comment("Dana", "Perfect timing for my homework."));

        // Add comments to video 2
        video2.AddComment(new Comment("Eve", "Abstraction finally clicked for me."));
        video2.AddComment(new Comment("Frank", "Great examples."));
        video2.AddComment(new Comment("Grace", "Could you cover encapsulation next?"));

        // Add comments to video 3
        video3.AddComment(new Comment("Henry", "The project structure is super helpful."));
        video3.AddComment(new Comment("Ivy", "I followed along and it worked!"));
        video3.AddComment(new Comment("Jack", "What about adding authentication?"));
        video3.AddComment(new Comment("Karen", "One of the best tutorials I've watched."));

        // Add comments to video 4
        video4.AddComment(new Comment("Leo", "Started from zero and now I feel confident."));
        video4.AddComment(new Comment("Mia", "The pace is perfect for beginners."));
        video4.AddComment(new Comment("Noah", "Highly recommended."));

        // Put all videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title:  {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}