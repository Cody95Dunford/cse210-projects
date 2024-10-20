using System.Numerics;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!\n");
        Console.WriteLine(_description);
        
        Console.Write("\nHow long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine().ToString());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!\n");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b"); // Erase the + character
        
        Console.Write("|"); // Replace it with the - character
        Thread.Sleep(250);
        Console.Write("\b \b"); // Erase the + character
        
        Console.Write("/"); // Replace it with the - character
        Thread.Sleep(250);
        Console.Write("\b \b"); // Erase the + character
        
        Console.Write("-"); // Replace it with the - character
        Thread.Sleep(250);
        Console.Write("\b \b"); // Erase the + character
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}