using System.Numerics;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        // List<Goal> _goals = new List<Goal>();
        _score = 0;

    }

    public void Start()
    {
        // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        int choice = 0;

        do
        {
            // display menu and ask user for option
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            // Create New Goal
            if (choice == 1)
            {

                CreateGoal();

            } else if (choice == 2)
            {
                // List every goal, description and if its completed
                ListGoalDetails();

            } else if (choice == 3)
            {
                Console.Write("What is the filename? ");

                string filename = Console.ReadLine();

                SaveGoals(filename);
            }

            Console.WriteLine();

            DisplayPlayerInfo();

            Console.WriteLine();


        } while (choice != 6);

    }

    public void DisplayPlayerInfo()
    {

        Console.WriteLine($"You have {GetScore()} points.");

    }

    public int GetScore()
    {
        return _score;
    }

    public void ListGoalNames()
    {
        // return "";

    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        // foreach(Goal goal in _goals)
        // {
        //     Console.WriteLine($"{goal.GetDetailsString()}");
        // }

        for(int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        // CreateGoal - Ask the user for the information about a new goal. Then, creates the goal and adds it to the list.
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. CheckList Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description to it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == 1)
            {
                // Instance of the SimpleGoal Class 
                SimpleGoal simpleGoal = new SimpleGoal(name,description,points);

                // Add the goal to the _goals List
                _goals.Add(simpleGoal);

            } 
            else if (goalType == 2)
            {
                // Instance of the EternalGoal Class
                EternalGoal eternalGoal = new EternalGoal(name,description,points);

                // Add the goal to the _goals List
                _goals.Add(eternalGoal);
            }
            else if (goalType == 3)
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus =  int.Parse(Console.ReadLine());

                // Instance of the CheckListGoal Class
                CheckListGoal checkListGoal = new CheckListGoal(name,description,points,target,bonus);

                // Add the goal to the _goals List
                _goals.Add(checkListGoal);
            }

    }


    public void RecordEvent()
    {


    }

    public void SaveGoals(string filename)
    {
        Console.WriteLine("Saving to file...");

        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
       

    }

    public void LoadGoals()
    {

    }


}