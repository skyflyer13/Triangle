namespace TriangleAnalyzer;

[Flags]
public enum TriangleType
{
    /// <summary>
    /// Enakostranicni
    /// </summary>
    Equilateral = 1,

    /// <summary>
    /// Enakokraki
    /// </summary>
    Isosceles = 2,

    /// <summary>
    /// Pravokotni
    /// </summary>
    RightAngled = 4,

    /// <summary>
    /// Raznostranicni
    /// </summary>
    Scalene = 8
}

public static class TriangleTypeDeterminer
{
    public static TriangleType DetermineTriangleType(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Wrong arguments!");
        }
        TriangleType result = 0;
        if (a == b && b == c)
        {
            result = result | TriangleType.Equilateral;
        }

        if (a == b || a == c || b == c)
        {
            result = result | TriangleType.Isosceles;
        }

        if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2) ||
                 (Math.Pow(a, 2) + Math.Pow(c, 2)) == Math.Pow(b, 2) ||
                 (Math.Pow(b, 2) + Math.Pow(c, 2)) == Math.Pow(a, 2))
        {
            result = result | TriangleType.RightAngled;
        }

        if (a != b && a != c && b != c)
        {
            result = result | TriangleType.Scalene;
        }

        return result;
    }
}