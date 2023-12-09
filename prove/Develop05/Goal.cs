using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int NumPoints { get; set; }
    public bool IsComplete { get; set; }

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

    public virtual int DisplayPoints()
    {
        return NumPoints;
    }
    public virtual void CreateGoal(Goal goal)
    {
        Console.Write("What is the name of your goal? ");
        goal.Name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        goal.Description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        string numPointsString = Console.ReadLine();
        goal.NumPoints = int.Parse(numPointsString);
    }
    public abstract void RecreateGoal(Goal goal, string details);
    public virtual void ListGoals(Goal goal, int i)
    {
        if(goal.IsComplete)
        {
            Console.WriteLine($"{i}. [X] {goal.Name} ({goal.Description})");
        }
        else
        {
            Console.WriteLine($"{i}. [ ] {goal.Name} ({goal.Description})");
        }
    }
    public abstract string SaveGoal();
    public virtual void RecordGoal()
    {
        IsComplete = true;

        Console.WriteLine($"Congratulations! You have earned {NumPoints} points!");
    }
}