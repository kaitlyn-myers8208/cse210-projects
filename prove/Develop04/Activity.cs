public class Activity
{
    public string _nameActivity { get; set; }
    public string _description { get; set; }
    public int _duration { get; set; }

    public Activity(string nameActivity, string description, int duration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {

    }
    public void DisplayEndingMessage()
    {

    }
    public void DisplayTimer()
    {

    }
}