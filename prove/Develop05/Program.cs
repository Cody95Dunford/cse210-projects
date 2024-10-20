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
                /*List of prompts*/
                List<string> prompts = new List<string>();
                string prompt1 = "Think of a time when you stood up for someone else.";
                string prompt2 = "Think of a time when you did something really difficult.";
                string prompt3 = "Think of a time when you helped someone in need.";
                string prompt4 = "Think of a time when you did something truly selfless.";
                prompts.Add(prompt1);
                prompts.Add(prompt2);
                prompts.Add(prompt3);
                prompts.Add(prompt4);

                /*List of questions*/
                List<string> questions = new List<string>();
                string question1 = "Why was this experience meaningful to you?";
                string question2 = "Have you ever done anything like this before?";
                string question3 = "How did you get started?";
                string question4 = "How did you feel when it was complete?";
                questions.Add(question1);
                questions.Add(question2);
                questions.Add(question3);
                questions.Add(question4);

                /*Run 1st part of the activity*/
                Console.Clear();
                ReflectionActivity activity2 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times you have hown strength in your life.", 0, prompts, questions);
                activity2.DisplayStartingMessage();
                Console.Clear();
                activity2.Run();
                activity2.DisplayEndingMessage();
            }
            if (userInput == 3)
            {                
                List<string> prompts = new List<string>();
                string prompt1 = "Think of a time when you stood up for someone else.";
                string prompt2 = "Think of a time when you did something really difficult.";
                string prompt3 = "Think of a time when you helped someone in need.";
                string prompt4 = "Think of a time when you did something truly selfless.";
                prompts.Add(prompt1);
                prompts.Add(prompt2);
                prompts.Add(prompt3);
                prompts.Add(prompt4);

                Console.Clear();
                ListingActivity activity2 = new ListingActivity("Listing Activity", "This activity will prompt you to make a list of responses.", 0, 0, prompts);
                activity2.DisplayStartingMessage();
                Console.Clear();
                activity2.Run();
                activity2.DisplayEndingMessage();
            }
        }
    }
}