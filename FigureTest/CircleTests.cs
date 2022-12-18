using FiguresPass;

namespace FigureTest;

public class Tests
{
    private double _delta;
    [SetUp]
    public void Setup()
    {
        _delta = 0.01;
    }

    [Test]
    [TestCase(3, 28.27F)]
    [TestCase(4, 50.26F)]
    [TestCase(5, 78.54F)]
    public void Test_Circle_Area(float radius, float expected)
    {
        var circle = new Circle(radius);
        Assert.AreEqual(expected, circle.GetArea(), _delta);
    }

    [Test]
    [TestCase(float.NegativeInfinity)]
    [TestCase(float.PositiveInfinity)]
    [TestCase(float.NegativeZero)]
    [TestCase(float.NaN)]
    [TestCase(-1)]
    public void Test_Triangle_Area_Exceptions(float radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}
