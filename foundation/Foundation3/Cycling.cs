using System;

public class Cycling : Activity
{
    private double _speed;
    
    public Cycling(string date, double minutes, double speed)
    : base(date, minutes)
    {
        _speed =  speed;
    }

    public override double Distance()
    {
        return (_speed / 60) * _minutes;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return _date + " Cycling (" + _minutes + " min.)- Distance " + Math.Round(Distance(),1) + " miles, Speed "
        + Math.Round( Speed(),1) + " mph, " + "Pace: " + Math.Round(Pace(),1) + " minutes per mile";
    }
}