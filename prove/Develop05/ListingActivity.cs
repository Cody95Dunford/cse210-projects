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

    }

    /*GetRandomPrompt method*/
    public void GetRandomPrompt()
    {

    }

    /*GetListFromUser method: change to public list<string>*/
    public string GetListFromUser()
    {
        return "";
    }
}