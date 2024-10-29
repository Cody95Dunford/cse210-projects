using System;

public class Running : Activity
{
    private double _distance;
    public Running(string date, double minutes, double distance)
    : base(date, minutes)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double Pace()
    {
        return _minutes / _distance;
    }

    public override string GetSummary()
    {
        return _date + " Running (" + _minutes + " min.)- Distance " + Math.Round(Distance(),1) + " miles, Speed "
        + Math.Round( Speed(),1) + " mph, " + "Pace: " + Math.Round(Pace(),1) + " minutes per mile";
    }
}