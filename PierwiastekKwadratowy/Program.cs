using System;

public class QuadraticEquationSolver
{
    public static (double? x1, double? x2) Solve(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            return (null, null); // Brak pierwiastków rzeczywistych
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            return (x, null); // Jeden pierwiastek rzeczywisty
        }
        else
        {
            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double x1 = (-b + sqrtDiscriminant) / (2 * a);
            double x2 = (-b - sqrtDiscriminant) / (2 * a);
            return (x1, x2); // Dwa pierwiastki rzeczywiste
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Program do obliczania pierwiastków równania kwadratowego");
        Console.WriteLine("Podaj współczynniki równania ax^2 + bx + c = 0");

        Console.Write("Podaj a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Podaj c: ");
        double c = double.Parse(Console.ReadLine());

        (double? x1, double? x2) = Solve(a, b, c);

        Console.WriteLine("Wyniki:");
        Console.WriteLine("x1 = " + (x1.HasValue ? x1.ToString() : "brak pierwiastków rzeczywistych"));
        Console.WriteLine("x2 = " + (x2.HasValue ? x2.ToString() : "brak pierwiastków rzeczywistych"));
    }
}