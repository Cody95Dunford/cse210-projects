using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
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
        return false;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }    
}