using System;

class GoalManager
{
    /* class attributes */
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {

    }

    public void start()
    {
        /*declare variables*/
        int userInput = 0;
        string fileName = "goals.txt";

        /*while loop: This loop will display the different
        available activities until the user_input is 6. When 
        the user_input is 6, the program quits.*/
        while (userInput != 6)
        {
            Console.Clear();

            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                CreateGoal();
                
            }
            if (userInput == 2)
            {
                ListGoalDetails();
            }
            if (userInput == 3)
            {                
                SaveGoals(fileName);
            }
            if (userInput == 4)
            {
                LoadGoals(fileName);
            }
            if (userInput == 5)
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        int i = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine(i + ". " + goal.GetName());
            i++;
        } 
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            goal.GetDetailsString();
        }
    }

    public void CreateGoal()
    {
        /* display options to create a new goal */
        Console.WriteLine("The goal types are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal wopuld you like to create? ");
        int setGoal = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("\nWhat is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("\nWhat is the amount of points associated with your goal? ");
        int points = int.Parse(Console.ReadLine());
        if (setGoal == 1)
        {
            SimpleGoal loadGoal = new SimpleGoal(name, description, points, false);
            _goals.Add(loadGoal);  
        }
        else if (setGoal == 2)
        {
            EternalGoal loadGoal = new EternalGoal(name, description, points);
            _goals.Add(loadGoal);  
        }
        else if (setGoal == 3)
        {
            Console.WriteLine("How many times does this goal needs to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("How much is the bonus worth?");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal loadGoal = new ChecklistGoal(name, description, points, target, bonus, 0);
            _goals.Add(loadGoal);  
        } 
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you complete? ");
        int completedGoal = int.Parse(Console.ReadLine());
        if (completedGoal < _goals.Count)
        {
            _goals[completedGoal - 1].RecordEvent();
            _score += _goals[completedGoal - 1].GetPoints();
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _goals.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "Simple Goal")
            {
                SimpleGoal loadGoal = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
                _goals.Add(loadGoal);
            }
            else if (parts[0] == "Eternal Goal")
            {
                EternalGoal loadGoal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]));
                _goals.Add(loadGoal);
            }
            else
            {
                ChecklistGoal loadGoal = new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]));
                _goals.Add(loadGoal);
            }
        }      
    }
}