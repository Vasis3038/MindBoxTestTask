namespace AreaCalculator.Shapes;

public class Circle : IAreaCountable
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
        Validate();
    }

    public double CountArea()
    {
        if (double.IsInfinity(Math.PI * Math.Pow(Radius, 2)))
        {
            throw new ArgumentException("Area is too large, try shorter radius.");
        }

        return Math.PI * Math.Pow(Radius, 2);
    }

    public void Validate()
    {
        if (Radius < 0)
        {
            throw new ArgumentException("Radius cannot be negative.");
        }
    }
}
