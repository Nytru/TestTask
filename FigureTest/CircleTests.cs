using FiguresPass;

namespace FigureTest;

public class CircleTests
{
    [Test]
    [TestCase(3, 3 * 3 * MathF.PI)]
    [TestCase(4, 4 * 4 * MathF.PI)]
    [TestCase(5, 5 * 5 * MathF.PI)]
    public void Test_Circle_Area(float radius, float expected)
    {
        var circle = new Circle(radius);
        Assert.That(circle.GetArea(), Is.EqualTo(expected).Within(float.Epsilon));
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
    
    [Test]
    [TestCase(150, MathF.PI * 150 * 150)]
    [TestCase(200, MathF.PI * 200 * 200)]
    public void Static_Method_Test(float radius, float expected)
    {
        Assert.That(IFigure.GetArea(new Circle(radius)), Is.EqualTo(expected).Within(float.Epsilon));
    }
}
