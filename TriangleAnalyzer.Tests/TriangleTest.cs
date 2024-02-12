using Xunit.Sdk;

namespace TriangleAnalyzer.Tests;

public class UnitTest1
{
    [Fact]
    public void ArgumentsAreValidatedTest()
    {
        Assert.Throws<ArgumentException>(() =>
            {
                var result = TriangleTypeDeterminer.DetermineTriangleType(-1, 4, 5);
            });
    }

    [Fact]
    public void RightAngledTest()
    {
        var result = TriangleTypeDeterminer.DetermineTriangleType(3, 4, 5);
        Assert.Equal(TriangleType.RightAngled, result & TriangleType.RightAngled);
    }

    [Fact]
    public void ScaleneTest()
    {
        var result = TriangleTypeDeterminer.DetermineTriangleType(7, 8, 9);
        Assert.Equal(TriangleType.Scalene, result & TriangleType.Scalene);
    }

    [Fact]
    public void IsoscelesTest()
    {
        var result = TriangleTypeDeterminer.DetermineTriangleType(5, 5, 6);
        Assert.Equal(TriangleType.Isosceles, result & TriangleType.Isosceles);
    }

    [Fact]
    public void TriangleDeterminerReturnsMultipleTypes()
    {
        var result = TriangleTypeDeterminer.DetermineTriangleType(4, 4, 4);
        Assert.Equal(TriangleType.Equilateral, result & TriangleType.Equilateral);
        Assert.Equal(TriangleType.Isosceles, result & TriangleType.Isosceles);
    }

    [Theory]
    [InlineData(3, 4, 5, TriangleType.RightAngled | TriangleType.Scalene)]
    [InlineData(1, 1, 1, TriangleType.Equilateral | TriangleType.Isosceles)]
    [InlineData(7, 1, 1, TriangleType.Isosceles)]
    [InlineData(7, 8, 9, TriangleType.Scalene)]
    public void TrianglesTest(double a, double b, double c, TriangleType expectedResult)
    {
        var result = TriangleTypeDeterminer.DetermineTriangleType(a, b, c);

        Assert.Equal(expectedResult, result);
    }
}