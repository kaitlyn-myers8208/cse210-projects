public class Scripture
{
    public string _textBodyString { get; set; }
    public Reference _reference { get; set; }
    private List<Word> _textbody = new List<Word>();
    
    public Scripture(string textBody, Reference reference)
    {
        _textBodyString = textBody;
        // _textbody = ConvertToList();
        _reference = reference;        
    }


    public void ConvertToList()
    {
        string[] scriptureArray = _textBodyString.Split(" ");
    
        for (int i = 0; i < scriptureArray.Length; i++)
        {
            Word word = new Word();
            word.SetWord(scriptureArray[i]);
            _textbody.Add(word);
        }
    }
    public void DisplayText()
    {
        // Console.WriteLine($"{_textBodyString}");
        ConvertToList();
        foreach (Word w in _textbody)
        {
            Console.Write(w.GetWord() + " ");
            // return w + " ";
        }
        Console.WriteLine();
    }
    public void DisplayScripture()
    {
        // ConvertToList();
        // foreach (Word w in _textbody)
        // {
        //     Console.Write(w)
        // }
        _reference.DisplayReference();
        DisplayText();
        // Console.WriteLine($"{_reference.DisplayReference()} {DisplayText()}");
        // Console.WriteLine();
    }
    public void HideWords()
    {
        Random rnd = new Random(); 
        int randScripture = rnd.Next(1,_textbody.Count);

        
        
    }
}