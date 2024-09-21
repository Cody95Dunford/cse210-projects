using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        /*
        Objective:
            Make a collection of if statements that determine a student's grade based on
            percentage. The program will also send a statement whether they passed or 
            failed the class.
        Plan:
            1. Ask for grade in percentage.
            2. Get the user input and convert it into and int.
            3. Make if-else if-else statements determining letter grade.
            4. Display 2 different statements whether they passed or failed the class.
        */
        //get the user's grade by percentage
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        //convert user input into an int
        int grade = int.Parse(userInput);
        string letter = "";

        // conditional statement for 
        if (grade >= 90){
            letter = "A";
        }
        else if (grade >= 80){
            letter = "B";
        }
        else if (grade >= 70){
            letter = "C";
        }
        else if (grade >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70){
            Console.WriteLine("Congradulations, you passed the class!");
        }
        else{
            Console.WriteLine("Better luck next time.");
        }
    }
}