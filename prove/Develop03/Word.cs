public class Word
{
    private string _word;
    private bool _isHidden;

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
    public void SetHidden()
    {
        _isHidden = true;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
}