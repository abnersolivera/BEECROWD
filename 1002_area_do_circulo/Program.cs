namespace AreaOfCircle;

class Program
{
    static void Main(string[] args)
    {
        if (double.TryParse(Console.ReadLine(), out double ray))        
            Console.WriteLine($"A={(3.14159 * Math.Pow(ray, 2)).ToString("F4")}");        
        else        
            Console.WriteLine("Invalid input. Please enter a valid number.");        
    }
}