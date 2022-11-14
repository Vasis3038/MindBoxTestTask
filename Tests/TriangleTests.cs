using NUnit.Framework;
using AreaCalculator.Shapes;

namespace Tests;

public class TriangleTests
{

    [Test]
    public void NegativeArgsValidationFailureTest()
    { 
        Assert.Throws<ArgumentException>(() => new Triangle(-1, -2, -3));
    }

    [Test]
    public void IsNotTriangleValidationFailureTest()
    { 
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }

    [Test]
    public void TooLargeAreaTest()
    { 
        Assert.Throws<ArgumentException>(() 
            => new Triangle(double.MaxValue / 3, double.MaxValue / 3, double.MaxValue / 3).CountArea());
    }

    [Test]
    public void IsNotRightTriangleTest()
    { 
        Assert.False(new Triangle(3, 3, 3).IsRightTriangle());
    }

    [Test]
    public void IsRightTriangleTest()
    { 
        Assert.True(new Triangle(5, 12, 13).IsRightTriangle());
    }

    [Test]
    public void SuccessfullRightTriangleAreaCountTest()
    {
        Assert.AreEqual(30, new Triangle(5, 12, 13).CountArea());
    }

    [Test]
    public void SuccessfulTriangleAreaCountTest()
    {
        Assert.AreEqual(500, Math.Round(new Triangle(1, 1000, 1000).CountArea()));
    }
}