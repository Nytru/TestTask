namespace FiguresPass;

public class Triangle : IFigure
{
    private readonly float _a;
    private readonly float _b;
    private readonly float _c;

    public float A
    {
        get => _a;
        init
        {
            if (value <= 0 || float.IsNaN(value) || float.IsInfinity(value))
                throw new ArgumentException("Side of triangle must be positive number");
            _a = value;
        }
    }

    public float B
    {
        get => _b;
        init
        {
            if (value <= 0 || float.IsNaN(value) || float.IsInfinity(value))
                throw new ArgumentException("Side of triangle must be positive number");
            _b = value;
        }
    }

    public float C
    {
        get => _c;
        init
        {
            if (value <= 0 || float.IsNaN(value) || float.IsInfinity(value))
                throw new ArgumentException("Side of triangle must be positive number");
            _c = value;
        }
    }

    public Triangle(float a, float b, float c)
    {
        if (!(a + b > c) || !(a + c > b) || !(b + c > a))
            throw new ArgumentException("The sum of any two sides must be greater than the third");
        A = a;
        B = b;
        C = c;
    }

    public float GetArea()
    {
        float p = (A + B + C) / 2;
        return MathF.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
    
    public bool IsRight()
    {
        return MathF.Abs(A * A + B * B - C * C) < float.Epsilon || MathF.Abs(A * A + C * C - B * B) < float.Epsilon ||
               MathF.Abs(B * B + C * C - A * A) < float.Epsilon;
    }
}
