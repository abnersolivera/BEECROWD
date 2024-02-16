using System;

namespace Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"DIFERENCA = {DifferenceCalculation(ReadIntegerInput("A"), ReadIntegerInput("B"), ReadIntegerInput("C"), ReadIntegerInput("D"))}");
        }

        static int ReadIntegerInput(string message)
        {
            do
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                    return result;

                Console.WriteLine("Invalid input. Please enter a valid integer.");
            } while (true);
        }

        static int DifferenceCalculation(int a, int b, int c, int d)
        {
            return a * b - c * d;
        }
    }
}
