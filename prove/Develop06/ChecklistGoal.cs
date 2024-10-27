using System;

class ChecklistGoal : Goal
{
    /* class attributes */
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal( string name, string description, string points, int target, int bonus)
        : base(name, description, points)    
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        Console.Write("\nWhat is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("\nWhat is a short description of your goal? ");
        _description = Console.ReadLine();
        Console.Write("\nWhat is the amount of points associated with your goal? ");
        _points = Console.ReadLine();
        Console.Write("\nHow many times does this goal need to be accomplished for the bonus? ");
        _target = int.Parse(Console.ReadLine());
        Console.Write("\nWhat is the bonus for accomplishing it in that many times? ");
        _bonus = int.Parse(Console.ReadLine());
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