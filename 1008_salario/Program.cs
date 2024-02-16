namespace Wage;

class Program
{
    static void Main(string[] args)
    {
        int code = ReadInput<int>("Employee Code");
        int hours = ReadInput<int>("Employee Hours");
        double rate = ReadInput<double>("Employee Rate");

        Console.WriteLine($"NUMBER = {code}\nSALARY = U$ {CalculateWage(hours, rate):F2}");
    }

    static T ReadInput<T>(string message)
    {
        do
        {
            if (typeof(T) == typeof(int) && int.TryParse(Console.ReadLine(), out int resultInt))
                return (T)(object)resultInt;

            if (typeof(T) == typeof(double) && double.TryParse(Console.ReadLine(), out double resultDouble))
                return (T)(object)resultDouble;

            Console.WriteLine("Invalid input. Please enter a valid integer or double.");
        } while (true);
    }

    static double CalculateWage(int hours, double rate) => hours * rate;
}