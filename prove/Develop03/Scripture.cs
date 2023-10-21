public class Scripture
{
    public string _textBodyString { get; set; }
    public Reference _reference { get; set; }
    private List<Word> _textbody = new List<Word>();
    public int count;
    public int numElements;
    
    public Scripture(string textBody, Reference reference)
    {
        _textBodyString = textBody;
        _reference = reference;      
        count = 0;  
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
        numElements = _textbody.Count();
    }
    public void DisplayText()
    {
        // Console.WriteLine($"{_textBodyString}");
        // ConvertToList();
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
        int remainder = _textbody.Count() % 8;
        if (count <= (numElements - remainder))
        {
            for (int i = 0; i < 8; i++)
            {
                Random rnd = new Random(); 
                int randNum = rnd.Next(0,_textbody.Count);
                if (_textbody[randNum]._isHidden == false)
                {
                    _textbody[randNum].SetWord("___");
                    _textbody[randNum].SetHidden();
                }
                else
                {
                    i--;
                }
                count++;
            }
            DisplayScripture();
        }
        else
        {
            for (int j = 0; j < remainder; j++)
                {
                    Random rnd2 = new Random(); 
                    int randNum2 = rnd2.Next(0,_textbody.Count);
                    if (_textbody[randNum2]._isHidden == false)
                    {
                        _textbody[randNum2].SetWord("___");
                        _textbody[randNum2].SetHidden();
                    }  
                    count++;     
                }
                DisplayScripture();
        }
        
        // foreach (Word w in _textbody)
        // {
        //     Console.Write(w.GetWord() + " ");
        // }       
        
    }
}