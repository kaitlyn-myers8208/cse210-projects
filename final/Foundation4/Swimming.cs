public class Swimming : Activity
{
    public double NumOfLaps { get; set; }

    public Swimming(string date, int length, double laps) : base(date, length)
    {
        ActivityType = "Swimming";
        NumOfLaps = laps;
    }

    public override double CalculateDistance()
    {
        double distance = NumOfLaps * 50 / 1000;
        return distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (CalculateDistance() / LengthInMinutes) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace =  LengthInMinutes / CalculateDistance();
        return pace;
    }
}