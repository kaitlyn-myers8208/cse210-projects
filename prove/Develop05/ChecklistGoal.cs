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
    public override void CreateGoal()
    {

    }
    public override void ListGoals()
    {

    }
    public override void SaveGoal()
    {
        Console.WriteLine("What is the file name? ");
        string fileName = Console.ReadLine();
        Console.WriteLine("Saving file...");

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine(TotalPoints);
            foreach (Goal g in Goals)
            {
                outputFile.WriteLine($"{g.Name}|{g.Description}|{g.NumPoints}|{g.IsComplete}");
            }
        }
        Console.WriteLine("File saved.");
    } 
    public override void LoadGoal()
    {
        
    }
}