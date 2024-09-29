using System;

public class Entry{
    // work with time
    static DateTime theCurrentTime = DateTime.Now;
    public string dateText = theCurrentTime.ToShortDateString();

    public string prompt;

    public string text;

    public void Display(){
        Console.WriteLine($"{dateText} {prompt} ");
        Console.WriteLine($"> {text}");
    }
}