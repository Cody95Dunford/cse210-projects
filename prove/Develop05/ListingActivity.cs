using System.Diagnostics;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    /*ListingActivity Constructor*/
    public ListingActivity(string name, string description, int duration, int count, List<string> prompts)
        : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    /*Run method*/
    public void Run()
    {
        Console.WriteLine("Get Ready...");
        ShowSpinner(7);
        Console.WriteLine("Consider the following prompt.\n");
        GetRandomPrompt();
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        List<string> response = GetListFromUser();
        Console.WriteLine($"You listed {response.Count} items.");
    }

    /*GetRandomPrompt method*/
    public void GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        Console.WriteLine($"-- {_prompts[index]} --\n");
    }

    /*GetListFromUser method: change to public list<string>*/
    public List<string> GetListFromUser()
    {
        String temp = "";
        List<string> response = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        Console.WriteLine("");
        while (startTime < futureTime)
        {
            Console.Write("> ");
            temp = Console.ReadLine();
            response.Add(temp);
            startTime = DateTime.Now;
        }
        return response;
    }
}