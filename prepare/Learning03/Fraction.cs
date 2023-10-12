using System.ComponentModel.DataAnnotations;

public class Fraction
{
    // public int _topNum 
    // { 
    //     get => _topNum;
    //     set => _topNum = value; 
    // }
    // public int _bottomNum
    // { 
    //     get => _bottomNum;
    //     set => _bottomNum = value; 
    // }
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }
    public Fraction(int topNum)
    {
        _topNum = topNum;
        _bottomNum = 1;
    }
    public Fraction(int topNum, int bottomNum)
    {
        _topNum = topNum;
        _bottomNum = bottomNum;
    }

    public int GetTop()
    {
        return _topNum;
    }
    public void SetTop(int topNum)
    {
        _topNum = topNum;
    }
    public int GetBottom()
    {
        return _bottomNum;
    }
    public void SetBottom(int bottomNum)
    {
        _bottomNum = bottomNum;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_topNum}/{_bottomNum}";
        return fractionString;
    }

    public double GetDecimalValue()
    {

        return (double)_topNum / (double)_bottomNum;
    }
}