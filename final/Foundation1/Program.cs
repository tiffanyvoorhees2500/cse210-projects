using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [];

        //Video 1
        Video video1 = new Video("How to print 3D","Tiffany Voorhees", 15);
        Comment comment1 = new Comment("Person 1", "Great video! Very informative");
        Comment comment2 = new Comment("Person 2", "This video was a litte confusing");
        Comment comment3 = new Comment("Person 3", "Very well made!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        videos.Add(video1);

        //Video 2
        Video video2 = new Video("Documentary","Author 2", 30);
        Comment v2comment1 = new Comment("Person 3", "Great video! Very informative");
        Comment v2comment2 = new Comment("Person 2", "This video was a litte confusing");
        Comment v2comment3 = new Comment("Person 6", "Very well made!");
        video2.AddComment(v2comment1);
        video2.AddComment(v2comment2);
        video2.AddComment(v2comment3);

        videos.Add(video2);

        //Video 3
        Video video3 = new Video("How to print 3D","Tiffany Voorhees", 15);
        Comment v3comment1 = new Comment("Person 4", "Great video! Very informative");
        Comment v3comment2 = new Comment("Person 2", "This video was a litte confusing");
        Comment v3comment3 = new Comment("Person 7", "Very well made!");
        video3.AddComment(v3comment1);
        video3.AddComment(v3comment2);
        video3.AddComment(v3comment3);

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}