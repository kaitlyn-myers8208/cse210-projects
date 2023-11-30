public abstract class Activity
{
    // USE KM
    public string ActivityType { get; set; }
    public string Date { get; set; }
    public int LengthInMinutes { get; set; }

    public Activity(string date, int length)
    {
        Date = date;
        LengthInMinutes = length;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public string DisplaySummary()
    {
        string summary = $"{Date} {GiveActivityType()} ({LengthInMinutes} min): Distance {CalculateDistance()} km, Speed {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
        return summary;
    }
    public string GiveActivityType()
    {
        return ActivityType;
    }
}