using FiguresPass;

namespace FigureTest;

public class TriangleTests
{
    private const double Precision = 0.0001;
    
    [Test]
    [TestCase(2, 2, 3, 1.9843135)]
    [TestCase(3, 3, 3, 3.8971143)]
    [TestCase(4, 4, 4, 6.928203)]
    public void Test_Triangle_Area_Sides(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);
        Assert.That(triangle.GetArea(), Is.EqualTo(expected).Within(Precision));
    }
    
    [Test]
    [TestCase(1, 2, 3)]
    [TestCase(0, 0, double.NegativeZero)]
    [TestCase(-1, -2, -3)]
    [TestCase(double.NegativeInfinity, double.NegativeInfinity, double.NaN)]
    public void Test_Triangle_Area_Sides_Invalid(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Test]
    [TestCase(5, 12, 13)]
    [TestCase(8000, 15000, 17000)]
    [TestCase(0.0003, 0.0004, 0.0005)]
    public void Triangle_Is_Right(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.That(triangle.IsRight(), Is.True);
    }
    
    [Test]
    [TestCase(5, 12, 14)]
    [TestCase(8000, 15000, 18000)]
    [TestCase(0.0003, 0.0004, 0.0006)]
    public void Triangle_Is_Not_Right(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.That(triangle.IsRight(), Is.False);
    }
}
