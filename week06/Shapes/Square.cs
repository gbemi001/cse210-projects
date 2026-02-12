public class Square : Shape
{
    private double _sideLength;

    public Square(string color, double sideLength) : base()
    {
        _sideLength = sideLength;
        _color = color;
    }

    public override double GetArea()
    {
        return _sideLength * _sideLength;
    }
}