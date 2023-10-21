using System.Threading.Tasks.Dataflow;

public class Reference
{
    public string _book { get; set; }
    public string _chapter { get; set; }
    public string _verse { get; set; }
    public string _secondVerse { get; set; }

    
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = "";

    }
    public Reference(string book, string chapter, string verse, string secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = secondVerse;

    }
    // public void DisplayReference()
    // {
    //     if(_secondVerse.Length > 0)
    //     {
    //         Console.WriteLine($"{_book} {_chapter}:{_verse}-{_secondVerse}");
    //     }
    //     else if(_secondVerse.Length == 0)
    //     {
    //         Console.WriteLine($"{_book} {_chapter}:{_verse}");
    //     }
    //     else
    //     {
    //         Console.WriteLine("That's not a correct verse");
    //     }
    // }
    public string DisplayReference()
    {
        if(_secondVerse.Length > 0)
        {
            return _book + " " + _chapter + ":" + _verse + "-" + _secondVerse;
        }
        else if(_secondVerse.Length == 0)
        {
            return _book + " " + _chapter + ":" + _verse;
        }
        else
        {
            return "That's not a correct verse";
        }
    }
}