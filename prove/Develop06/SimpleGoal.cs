using System;

class SimpleGoal : Goal
{
    /* class attributes */
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points)
    : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.Write("\nWhat is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("\nWhat is a short description of your goal? ");
        _description = Console.ReadLine();
        Console.Write("\nWhat is the amount of points associated with your goal? ");
        _points = Console.ReadLine();
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "[ ] " + _name + " (" + _description + ")";
    }
}