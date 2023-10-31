using System.Threading.Tasks.Dataflow;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _secondVerse;

    
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
    public void DisplayReference()
    {
        if(_secondVerse.Length > 0)
        {
            Console.Write($"{_book} {_chapter}:{_verse}-{_secondVerse} ");
        }
        else if(_secondVerse.Length == 0)
        {
            Console.Write($"{_book} {_chapter}:{_verse} ");
        }
        else
        {
            Console.WriteLine("That's not a correct verse");
        }
    }
    // public string DisplayReference()
    // {
    //     if(_secondVerse.Length > 0)
    //     {
    //         return _book + " " + _chapter + ":" + _verse + "-" + _secondVerse;
    //     }
    //     else if(_secondVerse.Length == 0)
    //     {
    //         return _book + " " + _chapter + ":" + _verse;
    //     }
    //     else
    //     {
    //         return "That's not a correct verse";
    //     }
    // }
}