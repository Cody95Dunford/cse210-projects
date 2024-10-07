using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        do{
            // display the reference and scripture
            Console.WriteLine(reference1.GetDisplayText() + scripture1.GetDisplayText());
            // instructions for the user
            Console.WriteLine("Press enter to continue, or type 'quit' to finish");
            string response = Console.ReadLine();
            /* if statement:
            if the user presses 'enter' then program hides 3 random words.
            if the user types 'quit' then the program exits.
            */
            if (response == ""){
                Random hidingNumber = new Random();
                int actualNumber = hidingNumber.Next(1, 4);
                scripture1.HideRandomWords(3);
                Console.Clear();
            }
            else if (response == "quit"){
                Environment.Exit(0);
            }            
        } while (scripture1.IsCompletelyHidden() == false);
        Console.WriteLine(reference1.GetDisplayText() + scripture1.GetDisplayText());
    }
}