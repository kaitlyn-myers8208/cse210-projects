
public class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {}
    public SimpleGoal(string name, string description, int numPoints) : base(name, description, numPoints)
    {

    }


    public override void DisplayGoal()
    {

    }
    public override void SaveGoals(List<Goal> goals)
    {
    
    }
    // public override void ListGoals()
    // {

    // }
    // public override void SaveGoals()
    // {
    //     // SimpleGoal newGoal = new SimpleGoal(); // added
    //     Console.WriteLine("What is the file name? ");
    //     string fileName = Console.ReadLine();
    //     Console.WriteLine("Saving file...");

    //     using (StreamWriter outputFile = new StreamWriter(fileName, true))
    //     {
    //         outputFile.WriteLine(TotalPoints);
    //         foreach (Goal g in newGoal.GetList()) // added
    //         {
    //             outputFile.WriteLine($"SimpleGoal:{g.Name}|{g.Description}|{g.NumPoints}|{g.IsComplete}");
    //         }
    //     }
    //     Console.WriteLine("File saved.");
    // } 
    // public override void SaveGoals()
    // {
    //     outputFile.WriteLine($"SimpleGoal:{g.Name}|{g.Description}|{g.NumPoints}|{g.IsComplete}");

    // } 
    // public override void LoadGoal()
    // {

    // }
}