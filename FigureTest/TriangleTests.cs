using FiguresPass;

namespace FigureTest;

public class TriangleTests
{
    [Test]
    [TestCase(2F, 2F, 3F, 1.9843135F)]
    [TestCase(3F, 3F, 3F, 3.8971143F)]
    [TestCase(4F, 4F, 4F, 6.928203F)]
    public void Test_Triangle_Area_Sides(float a, float b, float c, float expected)
    {
        var triangle = new Triangle(a, b, c);
        Assert.That(triangle.GetArea(), Is.EqualTo(expected).Within(float.Epsilon));
    }
    
    [Test]
    [TestCase(1, 2, 3)]
    [TestCase(0, 0, float.NegativeZero)]
    [TestCase(-1, -2, -3)]
    [TestCase(float.NegativeInfinity, float.NegativeInfinity, float.NaN)]
    public void Test_Triangle_Area_Sides_Invalid(float a, float b, float c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Test]
    [TestCase(3, 4, 5)]
    [TestCase(5, 12, 13)]
    [TestCase(8, 15, 17)]
    public void Triangle_Is_Right(float a, float b, float c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.That(triangle.IsRight(), Is.True);
    }
    
    [Test]
    [TestCase(3, 4, 6)]
    [TestCase(5, 12, 14)]
    [TestCase(8, 15, 18)]
    public void Triangle_Is_Not_Right(float a, float b, float c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.That(triangle.IsRight(), Is.False);
    }
    
    [Test]
    [TestCase(100, 100, 100, 4330.12702F)]
    [TestCase(17, 32, 28, 237.68454F)]
    public void Static_Method_Test(float a, float b, float c, float expected)
    {
        Assert.That(IFigure.GetArea(new Triangle(a, b, c)), Is.EqualTo(expected).Within(float.Epsilon));
    }
}
