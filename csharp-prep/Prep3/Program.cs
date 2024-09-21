using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        /*
        Objective:
            Make a guess the number game. If the guess is lower than the number, a prompt says "higher".
            If the guess is higher than the number, a prompt says "lower". The program stops with a correct 
            guess. 
        Plan:
            1. Generate a random number
            2. Create a user prompt to guess the number.
            3. Create a while loop.
            4. Create an if statement for a guess that is too high or too low.
            5. Loop ends with a correct guess.
        */
        Random randonGenerator = new Random();
        int magicNumber = randonGenerator.Next(1, 100);

        Console.WriteLine($"What is the magic number? {magicNumber}");

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNumber){

            if (guess > magicNumber){
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }

            else if (guess < magicNumber){
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }

        }
        
        Console.WriteLine("You are correct!");
    }
}