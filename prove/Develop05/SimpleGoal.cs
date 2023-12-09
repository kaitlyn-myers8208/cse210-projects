
public class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {}
    public SimpleGoal(string name, string description, int numPoints) : base(name, description, numPoints)
    {

    }
    public override void RecreateGoal(Goal goal, string details)
    {
        string[] parts = details.Split("|");
        Name = parts[0];
        Description = parts[1];
        string numPointsString = parts[2];
        NumPoints = int.Parse(numPointsString);
        string isCompleteString = parts[3];
        IsComplete = bool.Parse(isCompleteString);
    }
    public override string SaveGoal()
    {
        return $"SimpleGoal:{Name}|{Description}|{NumPoints}|{IsComplete}";
    }
}