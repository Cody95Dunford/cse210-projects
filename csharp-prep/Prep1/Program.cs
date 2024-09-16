using System;

class Program
{
    static void Main(string[] args)
    {
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