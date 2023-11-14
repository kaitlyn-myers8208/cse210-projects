using System.Runtime.CompilerServices;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int NumPoints { get; set; }
    public List<Goal> Goals { get; set; }
    // private List<Goal> Goals = new List<Goal>();

    public Goal()
    {
        Name = "void";
        Description = "void";
        NumPoints = 0;
    }
    public Goal(string name, string description, int numPoints)
    {
        Name = name;
        Description = description;
        NumPoints = numPoints;
    }

    public void AddPoints(int numPoints)
    {
        NumPoints += numPoints;
    }
    public int DisplayCurrentPoints()
    {
        return NumPoints;
    }
    public abstract void DisplayGoal();
    public abstract void CreateGoal();
    public abstract void ListGoals();
    public abstract void SaveGoal();
    public abstract void LoadGoal();
}