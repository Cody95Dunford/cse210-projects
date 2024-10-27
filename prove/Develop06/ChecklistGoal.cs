using System;

class ChecklistGoal : Goal
{
    /* class attributes */
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal( string name, string description, int points, int target, int bonus, int amount)
        : base(name, description, points)    
    {
        _target = target;
        _bonus = bonus;
        _amountComplete = amount;
    }

    public override void RecordEvent()
    {
        _amountComplete++;
    }

    public override bool isComplete()
    {
        if (_amountComplete == _target)
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        if (isComplete())
            return "[X] " + _name + " (" + _description + ")" + " --" + _amountComplete + "/" + _target;
        return "[ ] " + _name + " (" + _description + ")" + " --" + _amountComplete + "/" + _target;
    }

    public override string GetStringRepresentation()
    {
        return "Checklist Goal," + _name + "," + _description + "," + _points + "," + _target + "," + _bonus + "," + _amountComplete;
    }    
}