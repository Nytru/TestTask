using FiguresPass;

namespace FigureTest;

public class TriangleTests
{
    private double _delta;
    [SetUp]
    public void Setup()
    {
        _delta = 0.01;
    }
    
    [Test]
    [TestCase(2, 2, 3, 1.98F)]
    [TestCase(3, 3, 3, 3.9F)]
    [TestCase(4, 4, 4, 6.93F)]
    public void Test_Triangle_Area_Sides(float a, float b, float c, float expected)
    {
        var triangle = new Triangle(a, b, c);
        Assert.AreEqual(expected, triangle.GetArea(), _delta);
    }
    
    [Test]
    [TestCase(1, 2, 3)]
    [TestCase(0, 0, float.NegativeZero)]
    [TestCase(-1, -2, -3)]
    [TestCase(float.NegativeInfinity, float.NegativeInfinity, float.PositiveInfinity)]
    public void Test_Triangle_Area_Sides_Invalid(float a, float b, float c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
}