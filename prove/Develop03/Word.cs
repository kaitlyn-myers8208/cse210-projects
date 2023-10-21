public class Word
{
    private string _word;
    public bool _isHidden { get; set; }

    public void SetWord(string word)
    {
        _word = word;
    }
    public string GetWord()
    {
        return _word;
    }
    public void DisplayWord()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        if (_word.Length == 0)
        {
            _isHidden = true;
        }
        return _isHidden;   
    }
}