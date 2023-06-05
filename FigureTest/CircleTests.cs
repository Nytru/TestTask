using FiguresPass;

namespace FigureTest;

public class CircleTests
{
    private const double Precision = 0.0001;
    
    [Test]
    [TestCase(3, 3D * 3D * Math.PI)]
    [TestCase(4000, 4000D * 4000D * Math.PI)]
    [TestCase(0.0005, 0.0005D * 0.0005D * Math.PI)]
    public void Test_Circle_Area(double radius, double expected)
    {
        var circle = new Circle(radius);
        Assert.That(circle.GetArea(), Is.EqualTo(expected).Within(Precision));
    }

    [Test]
    [TestCase(double.NegativeInfinity)]
    [TestCase(double.PositiveInfinity)]
    [TestCase(double.NegativeZero)]
    [TestCase(double.NaN)]
    [TestCase(-1)]
    public void Test_Triangle_Area_Exceptions(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}
