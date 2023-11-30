public class OutdoorGathering : Event
{
    public string WeatherForcast { get; set; }
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForcast) : base (title, description, date, time, address)
    {
        WeatherForcast = weatherForcast;
    }

    public string DisplayExtraDetails()
    {
        string info = $"The weather will be {WeatherForcast}";
        return info;
    }
    public string DisplayShortDescription()
    {
        string shortDescription = $"This event is an Outdoor Gathering\n{Title}: {Description} on {Date}";
        return shortDescription;
    }
}