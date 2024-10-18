using System;

class Program
{
    static void Main(string[] args)
    {
        /*Step 3: Create the base class*/
        Assignment assignment = new Assignment("Samual Bennett", "Multiplication");

        /*Step 4: Create the mathAssignment class*/
        assignment.GetSummary();        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        /*Step 5: Create the writingAssignment class*/
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}