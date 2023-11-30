public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public string DisplayExtraDetails()
    {
        string info = $"Speaker: {Speaker}, Capacity: {Capacity}";
        return info;
    }
    public string DisplayShortDescription()
    {
        string shortDescription = $"This event is a Lecture\n{Title}: {Description}\n{Date}";
        return shortDescription;
    }
}