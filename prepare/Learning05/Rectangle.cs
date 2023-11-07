public class Rectangle : Shape
{
    public double _length { get; set; }
    public double _width { get; set; }
    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        double area = _length * _width;
        
        return area;
    }
}