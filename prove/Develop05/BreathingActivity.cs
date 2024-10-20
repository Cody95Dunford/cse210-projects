using System.Diagnostics;

public class BreathingActivity : Activity
{
    /*BreathingActivity Constructor*/
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)    
    {

    }

    /*Run method*/
    public void Run(){
        Console.WriteLine("Get Ready...");
        ShowSpinner(7);
        Console.WriteLine("\n");
        for (int i = _duration/10; i > 0; i--){
        Console.Write("Breath in...");
        ShowCountDown(4);
        Console.WriteLine();
        Console.Write("Breath out...");
        ShowCountDown(6);
        Console.WriteLine("\n");
        Thread.Sleep(1000);
        }
    }
}