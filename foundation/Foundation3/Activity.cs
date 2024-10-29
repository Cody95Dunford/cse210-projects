using System;

public class Activity
{   /*define class attributes*/
    protected string _date;
    protected double _minutes;

    /*Activity constructor*/
    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    /*Distance method*/
    public virtual double Distance()
    {
        return 0;
    }

    public virtual double Speed()
    {
        return 0;
    }

    public virtual double Pace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }
}