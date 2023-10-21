public class Scripture
{
    public string _textBodyString { get; set; }
    public Reference _reference { get; set; }
    private List<Word> _textbody = new List<Word>();
    private List<string> _textBodyWords = new List<string>();
    
    public Scripture(string textBody, Reference reference)
    {
        _textBodyString = textBody;
        _reference = reference;        
    }

    public void fillList()
    {
        // Word word = new Word();
        // word = "yeet";
        // _textbody = "yeet";
    }
    public void DisplayText()
    {
        Console.WriteLine($"{_textBodyString}");
    }
    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference.DisplayReference()} {_textBodyString}");
        Console.WriteLine();
    }
    public void HideWords()
    {
    
    }
}