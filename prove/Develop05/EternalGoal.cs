public class EternalGoal : Goal
{
    public EternalGoal() : base()
    {}
    public EternalGoal(string name, string description, int numPoints) : base(name, description, numPoints)
    {}

    public override void RecreateGoal(Goal goal, string details)
    {
        string[] parts = details.Split("|");
        Name = parts[0];
        Description = parts[1];
        string numPointsString = parts[2];
        NumPoints = int.Parse(numPointsString);
    }
    public override string SaveGoal()
    {
        return $"EternalGoal:{Name}|{Description}|{NumPoints}";
    }
}