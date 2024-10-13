using System;

class Video{
    // class responsibilities
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length, List<Comment> comments){
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public void displayInformation(){
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in seconds: {_length}");
        Console.WriteLine("Comments");
        foreach (Comment comment in _comments){
            comment.displayComment();
        }
    }
}