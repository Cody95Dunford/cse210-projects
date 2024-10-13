using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> vid1_comments = new List<Comment>();
        Comment vid1_comment1 = new Comment("Joe Bob", "This is a great video");
        Comment vid1_comment2 = new Comment("Jill Jane", "This guy is so funny");
        vid1_comments.Add(vid1_comment1);
        vid1_comments.Add(vid1_comment2);

        Video video1 = new Video("Sample 1", "Author 1", 185, vid1_comments);
        video1.displayInformation();
    }
}