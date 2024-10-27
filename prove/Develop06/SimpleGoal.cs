using System;
using System.ComponentModel;

class SimpleGoal : Goal
{
    /* class attributes */
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete)
    : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;

    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (_isComplete)
            return "[X] " + _name + " (" + _description + ")";
        return "[ ] " + _name + " (" + _description + ")";
    }

    public override string GetStringRepresentation()
    {
        return "Simple Goal," +  _name + "," + _description + "," + _points + "," + _isComplete;
    }
}