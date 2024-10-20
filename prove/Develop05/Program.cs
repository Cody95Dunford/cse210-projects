using System;

class Program
{
    static void Main(string[] args)
    {
        /*declare variables*/
        int userInput = 0;
        

        /*while loop: This loop will display the different
        available activities until the user_input is 4. When 
        the user_input is 4, the program quits.*/
        while (userInput != 4){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.Clear();
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by helping you breath.", 0);
                activity1.DisplayStartingMessage();
                Console.Clear();
                activity1.Run();
                activity1.DisplayEndingMessage();
            }
            if (userInput == 2)
            {
                
            }
            if (userInput == 3)
            {
                
            }
        }
    }
}