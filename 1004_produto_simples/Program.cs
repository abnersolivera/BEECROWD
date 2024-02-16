using System;

namespace SimpleProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"PROD = {ReadIntegerInput("Enter the first number: ") * ReadIntegerInput("Enter the second number: ")}");
        }

        static int ReadIntegerInput(string message)
        {
            do
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out int result))
                    return result;

                Console.WriteLine("Invalid input. Please enter a valid integer.");
            } while (true);
        }
    }

    
}
