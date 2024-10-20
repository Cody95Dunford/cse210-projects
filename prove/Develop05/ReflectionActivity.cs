using System.Diagnostics;

public class ReflectionActivity : Activity
{   /*class attributes*/
    private List<string> _prompts;
    private List<string> _questions;

    /*ReflectionActivity Constructor*/
    public ReflectionActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
    : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    /*Run method*/
    public void Run()
    {

    }

    /*GetRandomPrompt method*/
    public void GetRandomPrompt()
    {

    }

    /*GetRandomQuestion method*/
    public void GetRandomQuestion()
    {

    }

    /*DisplayPrompt method*/
    public void DisplayPrompt()
    {

    }

    /*DisplayQuestion method*/
    public void DisplayQuestion()
    {

    }
}