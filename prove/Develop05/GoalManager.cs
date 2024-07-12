using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _filename;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        int menuOption = 0;
        do
        {
            //Show current score
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");

            //Menu Items
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuOption = int.Parse(Console.ReadLine());

            if (menuOption == 1)
            {
                CreateGoal();
            }
            if (menuOption == 2)
            {
                ListGoalDetails();
            }
            if (menuOption == 3)
            {
                SaveGoals();
            }
            if (menuOption == 4)
            {
                LoadGoals();
            }
            if (menuOption == 5)
            {
                RecordEvent();
            }
            if (menuOption == 6)
            {
                Console.Clear();
                Console.WriteLine("You have quit the program.");
            }

        } while (menuOption != 6);
    }

    public void DisplayPlayerInfo()
    {
        string levelString;
        if (_score >= 100 && _score < 1000)
        {
            levelString = $"{_score.ToString()[0]}";
        }
        else if (_score >= 1000)
        {
            levelString = "10. Congratulations you have reached the highest level possible!";
        }
        else
        {
            levelString = "1";
        }

        Console.WriteLine($"You have {_score} points and you are Level {levelString}.");
    }

    public void ListGoalNames()
    {
        int goalNumber = 0;

        foreach (Goal goal in _goals)
        {
            goalNumber++;
            Console.WriteLine($"{goalNumber}. {goal.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        int goalNumber = 0;

        Console.Clear();
        Console.WriteLine("Here are all your goals:");
        Console.WriteLine("");
        foreach (Goal goal in _goals)
        {
            goalNumber++;
            string completedString = "[ ]";
            if (goal.IsCompleted() == true)
            {
                completedString = "[X]";
            }
            Console.WriteLine($"{goalNumber}. {completedString} {goal.GetGoalDetails()}");
        }
    }

    public void CreateGoal()
    {
        string name = "";
        string shortDescription = "";
        int points = 0;
        int goalType = 0;

        Console.Clear();
        Console.WriteLine($"The types of Goals you can create are: ");
        Console.WriteLine($"    1. Simple goal");
        Console.WriteLine($"    2. Eternal goal");
        Console.WriteLine($"    3. Checklist goal");
        Console.Write("What type of goal would you like to create? ");
        goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        shortDescription = Console.ReadLine();

        Console.Write("How many points is your goal worth? ");
        points = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, shortDescription, points);
            //Add goal to _goals list
            _goals.Add(simpleGoal);
        }
        if (goalType == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, shortDescription, points);
            //Add goal to _goals list
            _goals.Add(eternalGoal);
        }
        if (goalType == 3)
        {
            int targetTimes = 0;
            int bonus = 0;
            Console.Write("How many times would you like to complete this goal? ");
            targetTimes = int.Parse(Console.ReadLine());

            Console.Write("How many bonus points should you get when completed? ");
            bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, shortDescription, points, targetTimes, bonus);

            //Add goal to _goals list
            _goals.Add(checklistGoal);
        }

        Console.Clear();
        Console.WriteLine("Your new goal has been added. Don't forget to save!");
    }

    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Good Job! Here is a list of your goals.");
        Console.WriteLine("");
        ListGoalNames();
        Console.Write("Which goal did you want to record? ");
        int goalSelection = int.Parse(Console.ReadLine());

        Goal goal = _goals[goalSelection - 1];
        goal.RecordEvent();
        int pointsEarned = 0;
        pointsEarned += goal.GetPoints();
        if (goal.IsCompleted() == true)
        {
            pointsEarned += goal.GetBonus();
        }

        _score += pointsEarned;

        Console.Clear();
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("What is the filename for the goal file? ");

        _filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(_filename))
        {
            //first line keeps the user current score
            file.WriteLine(_score);

            //loop through goals and add to txt file
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.Clear();
        Console.WriteLine("Your goals have been saved.");

    }

    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("What is the filename for the goal file? ");

        _filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_filename);

        _score = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("|");
            string type = parts[0];
            string name = parts[1];
            string shortDescription = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool isCompleted = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, shortDescription, points, isCompleted);
                _goals.Add(goal);
            }
            if (type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(name, shortDescription, points);
                _goals.Add(goal);
            }
            if (type == "ChecklistGoal")
            {
                int timesComplete = int.Parse(parts[4]);
                int targetTimes = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, shortDescription, points, timesComplete, targetTimes, bonus);
                _goals.Add(goal);
            }
        }

        Console.Clear();
        Console.WriteLine("You goals have been loaded.");
    }
}
