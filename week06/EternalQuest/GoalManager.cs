using System.Numerics;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
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

            } else if (choice == 4)
            {
                LoadGoals();
            } else if (choice == 5)
            {
                RecordEvent();
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
       Console.WriteLine("The goals are:");

        for(int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetGoalName()}");
        }
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
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");

        int accomplishedGoal = int.Parse(Console.ReadLine());

        accomplishedGoal--;

        if (_goals[accomplishedGoal].IsComplete() == false)
        {
            _goals[accomplishedGoal].RecordEvent();
            _score += _goals[accomplishedGoal].GetPoints();
            Console.WriteLine($"You now have {_score} points.");

        } else {
            Console.WriteLine("You have already completed this goal.");
        }



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
        Console.Write("What is the filename for the goal file? ");

        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        // We erase the goals we had if there were any for this goals that we will load
        _goals.Clear();

        // Save the points
        _score = int.Parse(lines[0]);

        foreach(string line in lines)
        {
            // we will ignore the line where the points are
            if (line != "0")
            {
                // each line will be divided in parts separated by a comma
                string[] parts = line.Split(",");

                //Get the type of goal first
                string goalType = parts[0];
                
                // all goals have this variables
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);


                // create different instance depending on the type of goal and add to goals list
                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal simpleGoal = new SimpleGoal(name,description,points,isComplete);

                    _goals.Add(simpleGoal);

                } else if (goalType == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(name,description,points);

                    _goals.Add(eternalGoal);

                } else if(goalType == "CheckListGoal")
                {
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);

                    CheckListGoal checkListGoal = new CheckListGoal(name,description,points,amountCompleted,target,bonus);

                    _goals.Add(checkListGoal);
                }
            }
        }

    }


}