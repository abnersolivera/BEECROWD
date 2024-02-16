namespace AverageTwo;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        double c = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        Console.WriteLine($"MEDIA = {Average(a, b, c):F1}");
    }

    static double Average(double a, double b, double c)
    {
        double average = ((a * 2) + (b * 3) + (c * 5)) / 10.0;

        if (average >= 10.0)
            return 10.0;

        return average;
    }
}