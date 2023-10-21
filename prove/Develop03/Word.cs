public class Word
{
    public string _word { get; set; }
    public bool _isHidden { get; set; }

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