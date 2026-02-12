public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base()
    {
        _radius = radius;
        _color = color;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}