namespace FiguresPass;

public class Triangle : IFigure
{
    private const double Precision = double.Epsilon * 1000;
    
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public double A
    {
        get => _a;
        init => _a = value;
    }

    public double B
    {
        get => _b;
        init => _b = value;
    }

    public double C
    {
        get => _c;
        init => _c = value;
    }

    public Triangle(double a, double b, double c)
    {
        if (!(a + b > c) || !(a + c > b) || !(b + c > a))
            throw new ArgumentException("The sum of any two sides must be greater than the third");

        if (a <= 0 || double.IsNaN(a) || double.IsInfinity(a) ||
            b <= 0 || double.IsNaN(b) || double.IsInfinity(b) ||
            c <= 0 || double.IsNaN(c) || double.IsInfinity(c))
            throw new ArgumentException("Side of triangle must be positive number");
        A = a;
        B = b;
        C = c;
    }

    public double GetArea()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public bool IsRight()
    {
        return Math.Abs(A * A + B * B - C * C) < Precision || 
               Math.Abs(A * A + C * C - B * B) < Precision ||
               Math.Abs(B * B + C * C - A * A) < Precision;
    }
}