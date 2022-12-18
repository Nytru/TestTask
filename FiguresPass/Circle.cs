namespace FiguresPass;

public class Circle : IFigure
{
    public Circle(float radius)
    {
        Radius = radius;
    }
    
    private float _radius;
    
    public float Radius
    {
        get => _radius;
        init
        {
            if (value <= 0 || float.IsNaN(value) || float.IsInfinity(value))
                throw new ArgumentException("Radius must be positive");
            _radius = value;
        }
    }

    public  float GetArea()
    {
        return MathF.PI * Radius * Radius;
    }
}
