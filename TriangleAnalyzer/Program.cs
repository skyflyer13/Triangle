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

        Console.WriteLine(triangleType);
    }
}