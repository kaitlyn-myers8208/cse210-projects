using System.Formats.Asn1;

public class Square : Shape
{
    public double _side { get; set; }
    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        double area = _side * _side;
        
        return area;
    }
}