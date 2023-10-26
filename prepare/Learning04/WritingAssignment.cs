public class WritingAssignment : Assignment
{
    public string _title { get; set; }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        Console.WriteLine(GetSummary());
        return _title + " by " + _studentName;
    }
}