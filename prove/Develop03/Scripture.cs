public class Scripture
{
    public string _textBodyString { get; set; }
    public Reference _reference { get; set; }
    private List<Word> _textbody = new List<Word>();
    private int _count;
    private int _numElements;
    
    public Scripture(string textBody, Reference reference)
    {
        _textBodyString = textBody;
        _reference = reference;      
        _count = 0;  
    }


    public int GetCount()
    {
        return _count;
    }
    public int GetNumElements()
    {
        return _numElements;
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
        _numElements = _textbody.Count();
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
        // Console.WriteLine(remainder);
        // Console.WriteLine(_numElements);
        if (_count == _numElements - remainder)
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
                    else
                    {
                        j--;
                    }
                }
            _count = _count + remainder;
            // Console.WriteLine(_count);
            DisplayScripture();
            // Console.WriteLine($"The end _count is {_count}. Ending the program, sir");
            // Console.WriteLine(_numElements - remainder);
            // Console.WriteLine($"Remainder: {remainder}");
            // Console.WriteLine($"Number of elements: {_numElements}");
            return;
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                Random rnd = new Random(); 
                int randNum = rnd.Next(0,_textbody.Count);
                // Console.WriteLine("Making a new number");
                if (_textbody[randNum]._isHidden == false)
                {
                    string newString = new string('_', _textbody[randNum].GetWord().Length);
                    _textbody[randNum].SetWord(newString);
                    _textbody[randNum].SetHidden();
                }
                else
                {
                    i--;
                }
            }
            _count += 8;
            // Console.WriteLine(_count);
            DisplayScripture();
        } 
    }
}