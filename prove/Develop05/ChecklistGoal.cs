public class ChecklistGoal : Goal
{
    public int GoalLength { get; set; }

    public ChecklistGoal() : base()
    {}
    public ChecklistGoal(string name, string description, int numPoints) : base(name, description, numPoints)
    {

    }


    public override void DisplayGoal()
    {

    }
    public override void CreateGoal(Goal goal)
    {
        Console.Write("What is the name of your goal? ");
        Name = Console.ReadLine();
        Console.Write("\nWhat is a short description of it? ");
        Description = Console.ReadLine();
        Console.Write("\nHow many points is this goal worth? ");
        string numPointsString = Console.ReadLine();
        NumPoints = int.Parse(numPointsString);
        Console.Write("\nHow long should the goal go on for? ");
        string goalLengthString = Console.ReadLine();
        GoalLength = int.Parse(goalLengthString);
        // Goals.Add(goal);
    }
    public override void ListGoals(List<Goal> goals)
    {
        if (!IsComplete)
        {
            foreach (Goal g in goals)
            {
                int i = 1;
                Console.WriteLine($"{i}. [ ] {Name} ({Description})");
                i++;
            }
            // add number completed
        }
    }
    public override void SaveGoals(List<Goal> goals)
    {
        Console.WriteLine("What is the file name? ");
        string fileName = Console.ReadLine();
        Console.WriteLine("Saving file...");

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine(TotalPoints);
            foreach (Goal g in goals)
            {
                outputFile.WriteLine($"{g.Name}|{g.Description}|{g.NumPoints}|{g.IsComplete}");
            }
        }
        Console.WriteLine("File saved.");
    } 
    // public override void LoadGoal()
    // {
        
    // }
}