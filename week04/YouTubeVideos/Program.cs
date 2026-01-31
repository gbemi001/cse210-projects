using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Beauty of Nature", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Amazing video!"));
        video1.AddComment(new Comment("Bob", "Loved the scenery."));
        video1.AddComment(new Comment("Eve", "So relaxing to watch."));
        
        Video video2 = new Video("Tech Innovations 2024", "Jane Smith", 450);
        video2.AddComment(new Comment("Charlie", "Very informative."));
        video2.AddComment(new Comment("Diana", "Great insights on future tech."));
        video2.AddComment(new Comment("Eve", "Can't wait to see these innovations!"));

        Video video3 = new Video("Encapsulation Explained", "TechWorld", 720);
        video3.AddComment(new Comment("George", "Encapsulation finally makes sense."));
        video3.AddComment(new Comment("Hannah", "Clear and concise."));
        video3.AddComment(new Comment("Ivan", "Excellent breakdown."));

        List<Video> videos = new List<Video> 
        { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLengthInSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"\t{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine();
        }
    }
}