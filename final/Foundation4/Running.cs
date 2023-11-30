public class Running : Activity
{
    public double Distance { get; set; }

    public Running(string date, int length, double distance) : base(date, length)
    {
        ActivityType = "Running";
        Distance = distance;
    }

    public override double CalculateDistance()
    {
        return Distance;
    }
    public override double CalculateSpeed()
    {
        double speed = Distance / LengthInMinutes * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = LengthInMinutes / Distance;
        return pace;
    }
}