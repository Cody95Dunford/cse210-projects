using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Objective:
            This program will gather the first and last name of the user and arange their responses 
            in a specific way.
        Plan:
            1. Get user's first and last name.
            2. Arange input in a specific way.
        */
        // ask first name
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        // ask last name
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        // finished line
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}