using System;

class URI
{

    static void Main(string[] args)
    {

       CalculateArea(MultipleInput());
    }

    static void CalculateArea(IEnumerable<dynamic> values)
    {
        string[] input = values.ToList()[0].Split(' ');
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        Console.WriteLine($"TRIANGULO: {((1/2.0) * a * c):F3}");

    }

    static IEnumerable<dynamic> MultipleInput()
    {
        List<dynamic> inputs = new List<dynamic>
        {
            ReadInput("Enter value A, B, C: "),
        };

        inputs.ForEach(inputLine =>
        {
            string[] inputValues = ((string)inputLine).Split(' ');
            inputValues.ToList().ForEach(i => ValidValue<double>(i));
        });

        return inputs;
    }

    static T ValidValue<T>(string input)
    {
        if (double.TryParse(input, out double resultDouble))
            return (T)(object)resultDouble;

        throw new Exception($"Invalid input {input}. Please enter a valid double.");
    }

    static string ReadInput(string message) => Console.ReadLine()!.Trim();

}