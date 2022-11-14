using AreaCalculator.Shapes;
using NUnit.Framework;

namespace Tests;

public class AreaCalculatorTests
{
    [Test]
    public void SuccessfullAreaCountByCalculatorTest()
    {
        Assert.AreEqual(Math.PI * Math.Pow(10, 2), AreaCalculator.AreaCalculator.CalculateArea(new Circle(10)));
    }
}
