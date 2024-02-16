using System;
using System.Linq;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        Console.WriteLine($"VALOR A PAGAR: R$ {Products(MultipleInput()):F2}");
    }

    static double Products(IEnumerable<dynamic> products)
    {
        string[] productOne = products.ToList()[0].Split(' ');
        string[] productTwo = products.ToList()[1].Split(' ');

        double result = CalculateProduct(productOne);
        result += CalculateProduct(productTwo);
        return result;
    }

    static double CalculateProduct(string[] products) => int.Parse(products[1]) * double.Parse(products[2]);

    static IEnumerable<dynamic> MultipleInput()
    {
        List<dynamic> inputs = new List<dynamic>
        {
            ReadInput("Enter value one: "),
            ReadInput("Enter value two: ")
        };

        inputs.ForEach(inputLine => {
            string[] inputValues = ((string)inputLine).Split(' ');
            inputValues.ToList().ForEach(i => ValidValue<string>(i));
        });

        return inputs;
    }

    static T ValidValue<T>(string input)
    {
        if (typeof(T) == typeof(int) && int.TryParse(input, out int resultInt))
            return (T)(object)resultInt;

        if (typeof(T) == typeof(double) && double.TryParse(input, out double resultDouble))
            return (T)(object)resultDouble;

        if(typeof(T) == typeof(string))
            return (T)(object)input;

        throw new Exception($"Invalid input {input}. Please enter a valid string, integer or double.");
    }

    static string ReadInput(string message) => Console.ReadLine()!.Trim();
}