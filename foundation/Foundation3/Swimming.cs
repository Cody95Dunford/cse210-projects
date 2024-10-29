using System;

public class Swimming : Activity
{
    private double _laps;
    public Swimming(string date, double minutes, double laps)
    : base(date, minutes)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return (_laps * 50) / 1000 * 0.62;
    }

    public override double Speed()
    {
        return (Distance() / _minutes) * 60;
    }

    public override double Pace()
    {
        return _minutes / Distance();
    }

    public override string GetSummary()
    {
        return _date + " Swimming (" + _minutes + " min.)- Distance " + Math.Round(Distance(),1) + " miles, Speed "
        + Math.Round( Speed(),1) + " mph, " + "Pace: " + Math.Round(Pace(),1) + " minutes per mile";
    }
}