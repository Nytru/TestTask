namespace FiguresPass;

public class Circle : IFigure
{
    public double Radius { get; init; }
    
    public Circle(double radius)
    {
        if (radius <= 0 || double.IsNaN(radius) || double.IsInfinity(radius))
            throw new ArgumentException("Radius must be positive");
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
