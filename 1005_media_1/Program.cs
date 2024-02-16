using System;

namespace AverageOne;

class Program
{
    static void Main(string[] args)
    {
        decimal a = decimal.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        decimal b = decimal.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        Console.WriteLine($"MEDIA = {Average(a, b):F5}");
    }

    static decimal Average(decimal a, decimal b)
    {
        decimal average = ((a * 3.5m) + (b * 7.5m)) / 11.00000m;

        if (average >= 10.00000m)        
            return 10.00000m;        

        return average;
    }
}
