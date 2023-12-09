public class ChecklistGoal : Goal
{
    public int GoalLength { get; set; }
    public int NumCompleted { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal() : base()
    {}
    public ChecklistGoal(string name, string description, int numPoints) : base(name, description, numPoints)
    {}


    public override int DisplayPoints()
    {
        if (IsComplete)
        {
            return NumPoints + BonusPoints;
        }
        else
        {
            return NumPoints;
        }
    }
    public override void CreateGoal(Goal goal)
    {
        Console.Write("What is the name of your goal? ");
        Name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        Description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        string numPointsString = Console.ReadLine();
        NumPoints = int.Parse(numPointsString);
        Console.Write("How many times should you accomplish this goal for a bonus? ");
        string goalLengthString = Console.ReadLine();
        GoalLength = int.Parse(goalLengthString);
        Console.Write("How many bonus points? ");
        string bonusPointsString = Console.ReadLine();
        BonusPoints = int.Parse(bonusPointsString);
    }
    public override void RecreateGoal(Goal goal, string details)
    {
        string[] parts = details.Split("|");
        Name = parts[0];
        Description = parts[1];
        string numPointsString = parts[2];
        NumPoints = int.Parse(numPointsString);
        string bonusPointsString = parts[3];
        BonusPoints = int.Parse(bonusPointsString);
        string goalLengthstring = parts[4];
        GoalLength = int.Parse(goalLengthstring);
        string numCompletedString = parts[5];
        NumCompleted = int.Parse(numCompletedString);
        string isCompleteString = parts[6];
        IsComplete = bool.Parse(isCompleteString);
    }
    public override void ListGoals(Goal goal, int i)
    {
        if(goal.IsComplete)
        {
            Console.WriteLine($"{i}. [X] {goal.Name} ({goal.Description}) -- Currently Completed: {GoalLength}/{GoalLength}");
        }
        else
        {
            Console.WriteLine($"{i}. [ ] {goal.Name} ({goal.Description}) -- Currently Completed: {NumCompleted}/{GoalLength}");
        }
    }

    public override string SaveGoal()
    {
        return $"ChecklistGoal:{Name}|{Description}|{NumPoints}|{BonusPoints}|{GoalLength}|{NumCompleted}|{IsComplete}";
    }
    public override void RecordGoal()
    {
        NumCompleted++;
        if (NumCompleted == GoalLength)
        {
            IsComplete = true;
            Console.WriteLine($"Congratulations! You have earned {NumPoints} points and {BonusPoints} bonus points!");
            Console.WriteLine($"That's {NumPoints + BonusPoints} points in total!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {NumPoints} points!");
        }
    }
}