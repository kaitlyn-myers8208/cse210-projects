public class EternalGoal : Goal
{
    public EternalGoal() : base()
    {}
    public EternalGoal(string name, string description, int numPoints) : base(name, description, numPoints)
    {}


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
                outputFile.WriteLine($"EternalGoal:{g.Name}|{g.Description}|{g.NumPoints}|{g.IsComplete}");
            }
        }
        Console.WriteLine("File saved.");
    } 
    public override void LoadGoal()
    {
        
    }
}