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
            outputFile.WriteLine(NumPoints);
            foreach (Goal g in Goals)
            {
                outputFile.WriteLine($"{g.Name}|{g.Description}|{g.NumPoints}");
            }
        }
        Console.WriteLine("File saved.");
    } 
    public override void LoadGoal()
    {
        
    }
}