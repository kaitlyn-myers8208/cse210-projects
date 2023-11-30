public class Reception : Event
{
    public Reception(string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {

    }

    public string DisplayRSVPEmail()
    {
        string email = $"You've been invited to the {Title}, please RSVP at least 3 days prior to the event.";

        return email;
    }
    public string DisplayShortDescription()
    {
        string shortDescription = $"This event is a Reception\n{Title}: {Description} on {Date}";
        return shortDescription;
    }
}