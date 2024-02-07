namespace TriangleAnalyzer;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter side 1 of the triangle: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 of the triangle: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 of the triangle: ");
        double sideC = Convert.ToDouble(Console.ReadLine());

        var triangleType = TriangleTypeDeterminer.DetermineTriangleType(sideA, sideB, sideC);

        if (triangleType.HasFlag(TriangleType.Equilateral))
        {
            Console.WriteLine("Trikotnik je enakostranicni");
        }
        if (triangleType.HasFlag(TriangleType.Isosceles))
        {
            Console.WriteLine("Trikotnik je enakokraki");
        }
        if (triangleType.HasFlag(TriangleType.RightAngled))
        {
            Console.WriteLine("Trikotnik je pravokotni");
        }
        if (triangleType.HasFlag(TriangleType.Scalene))
        {
            Console.WriteLine("Trikotnik je raznostranicni");
        }
    }
}