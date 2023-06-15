using Xunit;

public class QuadraticEquationSolverTests
{
    [Fact]
    public void NoRealRoots()
    {
        // Arrange
        double a = 2;
        double b = 4;
        double c = 6;

        // Act
        (double? x1, double? x2) = QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        Assert.Null(x1);
        Assert.Null(x2);
    }

    [Fact]
    public void OneRealRoot()
    {
        // Arrange
        double a = 1;
        double b = -4;
        double c = 4;

        // Act
        (double? x1, double? x2) = QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        Assert.Equal(2, x1);
        Assert.Null(x2);
    }

    [Fact]
    public void TwoRealRoots()
    {
        // Arrange
        double a = 1;
        double b = -3;
        double c = -4;

        // Act
        (double? x1, double? x2) = QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        Assert.Equal(4, x1);
        Assert.Equal(-1, x2);
    }
}