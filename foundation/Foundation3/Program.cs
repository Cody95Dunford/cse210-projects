using System;

class Program
{
    static void Main(string[] args)
    {
        string now = DateTime.Now.ToString("dd MMM yyyy");

        /*create new Running instance*/
        Running run_activity = new Running(now,30,3);
        Console.WriteLine(run_activity.GetSummary());

        /*create new Running instance*/
        Cycling cycling_activity = new Cycling(now,30,6);
        Console.WriteLine(cycling_activity.GetSummary());

        /*create new Running instance*/
        Swimming swim_activity = new Swimming(now,30,100);
        Console.WriteLine(swim_activity.GetSummary());   
    }
}