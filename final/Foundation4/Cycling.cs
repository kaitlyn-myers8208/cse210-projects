public class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        ActivityType = "Cycling";
        Speed = speed;
    }

    public override double CalculateDistance()
    {
        double distance = LengthInMinutes * CalculateSpeed();
        return distance;
    }
    public override double CalculateSpeed()
    {
        return Speed;
    }
    public override double CalculatePace()
    {
        double pace = 60 / CalculateSpeed();
        return pace;
    }
}