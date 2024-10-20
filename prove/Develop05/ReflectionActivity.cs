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
        Console.WriteLine("Get Ready...");
        ShowSpinner(7);
        Console.WriteLine("Consider the following prompt.\n");
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Consider the following questions.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        string question1 = GetRandomQuestion();
        DisplayQuestion(question1);
        string question2 = GetRandomQuestion();
        DisplayQuestion(question2);
        Console.WriteLine();

    }

    /*GetRandomPrompt method*/
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }

    /*GetRandomQuestion method*/
    public string GetRandomQuestion()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_questions.Count);
        string question = _questions[index];
        _questions.Remove(_questions[index]);
        return question;
    }

    /*DisplayPrompt method*/
    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"-- {prompt} --\n");
    }

    /*DisplayQuestion method*/
    public void DisplayQuestion(string question)
    {
        Console.Write($"> {question} ");
        ShowSpinner(5);
        Console.WriteLine();
    }
}