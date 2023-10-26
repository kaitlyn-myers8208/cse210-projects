public class MathAssignment : Assignment
{
    public string _textbookSection { get; set; }
    public string _problems { get; set; }

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        Console.WriteLine(GetSummary());
        return "Section " + _textbookSection + " Problems " + _problems;
    }
}