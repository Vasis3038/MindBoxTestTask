namespace AreaCalculator.Shapes;

public class Triangle : IAreaCountable
{
    public double Side1 { get; private set; }
    public double Side2 { get; private set; }
    public double Side3 { get; private set; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;

        Validate();
    }

    public double CountArea()
    {
        double s;

        if (IsRightTriangle())
        {
            List<double> sides = new() { Side1, Side2, Side3 };
            sides.Sort();
            s = (sides[0] / 2) * sides[1];
        }
        else
        {
            double p = Side1 / 2 + Side2 / 2 + Side3 / 2;
            s = Math.Sqrt(p) * Math.Sqrt(p - Side1) * Math.Sqrt(p - Side2) * Math.Sqrt(p - Side3);
        }

        if (double.IsInfinity(s))
        {
            throw new ArgumentException($"The calculated area is too large, try shorter sides.");
        }

        return s;
    }

    public bool IsRightTriangle()
    {
        List<double> sides = new() { Side1, Side2, Side3 };
        sides.Sort();
        double sin = sides[0] / sides[2];
        double cos = sides[1] / sides[2];

        return Math.Round(sin * sin + cos * cos, 10) == 1;
    }

    private void Validate()
    {
        if (Side1 < 0 || Side2 < 0 || Side3 < 0)
        {
            throw new ArgumentException("Side length cannot be negative.");
        }

        if (Side1 - Side2 >= Side3 || Side2 - Side3 >= Side1 || Side3 - Side1 >= Side2)
        {
            throw new ArgumentException("Triangle condition not met.");
        }
    }
}
