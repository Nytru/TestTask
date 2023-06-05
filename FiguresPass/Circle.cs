namespace FiguresPass;

public class Circle : IFigure
{
    public Circle(double radius)
    {
        if (radius <= 0 || double.IsNaN(radius) || double.IsInfinity(radius))
            throw new ArgumentException("Radius must be positive");
        Radius = radius;
    }
    
    private double _radius;
    
    public double Radius
    {
        get => _radius;
        init => _radius = value;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
