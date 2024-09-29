using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        // needed variables
        int userInput = 0;
        Journal dailyJournal = new Journal();
        promptGenerator prompts = new promptGenerator();
        

        // while loop
        while (userInput <= 4){
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1){
                string randomPrompts = prompts.GetRamdomString();
                Console.WriteLine(randomPrompts);
                Entry dailyEntry = new Entry();
                dailyEntry.prompt = randomPrompts;
                Console.Write("> ");
                dailyEntry.text = Console.ReadLine().ToString();
                dailyJournal.AddEntry(dailyEntry);
            }
            else if (userInput == 2){
                dailyJournal.DisplayAll();
            }
            else if (userInput == 3){
                Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine().ToString();
                dailyJournal.LoadFromFile(fileName);
            }
            else if (userInput == 4){
                Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine().ToString();
                dailyJournal.SaveToFile(fileName);
            }
            else{
                Console.WriteLine("Good Bye");
            }
        }
    }
}