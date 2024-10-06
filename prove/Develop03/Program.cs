using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        do{
            Console.WriteLine(reference1.GetDisplayText() + scripture1.GetDisplayText());
            Console.WriteLine("Press enter to continue, or type 'quit' to finish");
            string response = Console.ReadLine();
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
    }
}