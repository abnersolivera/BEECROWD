namespace SalaryWithBonus;

class Program
{
    static void Main(string[] args)
    {
        ReadInput<string>("Employee Name");

        Console.WriteLine($"TOTAL = R$ {CalculateWage(ReadInput<double>("Employee Salary"), ReadInput<double>("Employee Sales")):F2}");
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

    static double CalculateWage(double salary, double sales) => sales > 0.00 ? salary + (sales * 0.15) : salary;
}