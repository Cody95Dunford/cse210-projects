using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> vid1_comments = new List<Comment>();
        Comment vid1_comment1 = new Comment("Joe Bob", "This is a great video.");
        Comment vid1_comment2 = new Comment("Jill Jane", "This guy is so funny.");
        Comment vid1_comment3 = new Comment("Jim Joe", "This made my day.");
        Comment vid1_comment4 = new Comment("Hannah Hanson", "I've been following him from the beginning. Love all his videos.");
        vid1_comments.Add(vid1_comment1);
        vid1_comments.Add(vid1_comment2);
        vid1_comments.Add(vid1_comment3);
        vid1_comments.Add(vid1_comment4);

        Video video1 = new Video("Comedy Video", "Author 1", 185, vid1_comments);
        video1.displayInformation();

        List<Comment> vid2_comments = new List<Comment>();
        Comment vid2_comment1 = new Comment("Ryan Reynolds", "What an amazing song!");
        Comment vid2_comment2 = new Comment("Micheal Scott", "This song almost brought tears in my eyes.");
        Comment vid2_comment3 = new Comment("Caitlin Clark", "My new favorite song.");
        Comment vid2_comment4 = new Comment("Jane Fulton", "You sing like an angel.");
        vid2_comments.Add(vid2_comment1);
        vid2_comments.Add(vid2_comment2);
        vid2_comments.Add(vid2_comment3);
        vid2_comments.Add(vid2_comment4);

        Video video2 = new Video("Music Video", "Author 2", 161, vid2_comments);
        video2.displayInformation();

        List<Comment> vid3_comments = new List<Comment>();
        Comment vid3_comment1 = new Comment("Ben Shapiro", "I completely agree with the one guy on the right.");
        Comment vid3_comment2 = new Comment("Ana Kasparian", "This is an important topic. Thanks for keeping it civil.");
        Comment vid3_comment3 = new Comment("Brian Kemp", "This is why we need the 1st Amendment. Keep talking about this topic");
        Comment vid3_comment4 = new Comment("Gillian Hans", "This shouldn't be a debate. The other side has rediculous views.");
        vid3_comments.Add(vid3_comment1);
        vid3_comments.Add(vid3_comment2);
        vid3_comments.Add(vid3_comment3);
        vid3_comments.Add(vid3_comment4);

        Video video3 = new Video("Political Debate Video", "Author 3", 203, vid3_comments);
        video3.displayInformation();
    }
}