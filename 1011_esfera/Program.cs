using System;

class URI
{

    static void Main(string[] args)
    {
        Console.WriteLine($"VOLUME = {CalculateVolume(ReadInput<double>("Enter the radius")):F3}");
    }

    static T ReadInput<T>(string message)
    {
        do
        {
            string userInput = Console.ReadLine()!.Trim();

            if (typeof(T) == typeof(int) && int.TryParse(userInput, out int resultInt))
                return (T)(object)resultInt;

            if (typeof(T) == typeof(double) && double.TryParse(userInput, out double resultDouble))
                return (T)(object)resultDouble;

            if (typeof(T) == typeof(string))
                return (T)(object)userInput;

            Console.WriteLine("Invalid input. Please enter a valid integer or double.");
        } while (true);
    }

    static double CalculateVolume(double radius) => (4.0 / 3) * 3.14159 * Math.Pow(radius, 3);
}