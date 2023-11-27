using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int NumPoints { get; set; }
    public int TotalPoints { get; set; }
    public bool IsComplete { get; set; }
    public List<Goal> Goals { get; set; } = new List<Goal>();
    // private List<Goal> Goals = new List<Goal>();

    // public List<Goal> GetList()
    // {
    //     return Goals;
    // }
    // public void AddtoList(Goal listItem)
    // {
    //     Goals.Add(listItem);
    // }

    public Goal()
    {
        Name = "void";
        Description = "void";
        NumPoints = 0;
        IsComplete = false;
    }
    public Goal(string name, string description, int numPoints)
    {
        Name = name;
        Description = description;
        NumPoints = numPoints;
        IsComplete = false;
    }

    public void AddPoints(int numPoints)
    {
        NumPoints += numPoints;
    }
    public int DisplayCurrentPoints()
    {
        return TotalPoints;
    }
    public abstract void DisplayGoal();
    public virtual void CreateGoal(Goal goal)
    {
        Console.Write("What is the name of your goal? ");
        goal.Name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        goal.Description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        string numPointsString = Console.ReadLine();
        goal.NumPoints = int.Parse(numPointsString);
        Goals.Add(goal);
    }
    public virtual void ListGoals()
    {
        Console.WriteLine("Listing goal within Goal part 1");
        int i = 1;
        foreach (Goal g in Goals)
        {
            Console.WriteLine($"{i}. [ ] {g.Name} ({g.Description})");
            i++;
            // Console.WriteLine("Listing goal within Goal part 2");
            // if (g.IsComplete == false)
            // {
            //     int i = 1;
            //     Console.WriteLine($"{i}. [ ] {g.Name} ({g.Description})");
            //     i++;
            // }
            // else if (g.IsComplete)
            // {
            //     int j = 1;
            //     Console.WriteLine($"{j}. [ ] {g.Name} ({g.Description})");
            //     j++;
            // }
        }
    }
    public abstract void SaveGoals();
    // public void LoadGoals()
    // {
    //     Console.WriteLine("What is the file name? ");
    //     string fileName = Console.ReadLine();
    //     Console.WriteLine("Loading file...");

    //     string[] lines = System.IO.File.ReadAllLines(fileName);
    //     foreach (string line in lines)
    //     {
    //         Console.WriteLine(line);            
    //     }
    // }
}