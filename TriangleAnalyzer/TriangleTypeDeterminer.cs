namespace TriangleAnalyzer;

public static class TriangleTypeDeterminer
{
    public static string DetermineTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "The triangle is equilateral.";
        }
        else if (a == b || a == c || b == c)
        {
            return "The triangle is isosceles.";
        }
        else if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2) ||
                 (Math.Pow(a, 2) + Math.Pow(c, 2)) == Math.Pow(b, 2) ||
                 (Math.Pow(b, 2) + Math.Pow(c, 2)) == Math.Pow(a, 2))
        {
            return "The triangle is right-angled.";
        }
        else
        {
            return "The triangle is scalene.";
        }
    }
}