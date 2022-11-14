using NUnit.Framework;
using AreaCalculator.Shapes;

namespace Tests;

public class CircleTests
{

    [Test]
    public void SuccessfullAreaCountTest()
    {
        Assert.AreEqual(Math.PI * Math.Pow(10, 2), new Circle(10).CountArea());
    }

    [Test]
    public void NegaticeRadiusValidationFailureTest()
    { 
        Assert.Throws<ArgumentException>(() => new Circle(-3));
    }

    [Test]
    public void TooLargeAreaValidationFailureTest()
    { 
        Assert.Throws<ArgumentException>(() => new Circle(double.MaxValue).CountArea());
    }
}
