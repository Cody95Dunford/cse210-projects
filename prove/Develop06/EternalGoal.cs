using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "[ ] " + _name + " (" + _description + ")";
    }

    public override string GetStringRepresentation()
    {
        return "Eternal Goal," + _name + "," + _description + "," + _points;
    }    
}