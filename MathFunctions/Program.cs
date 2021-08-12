using System;

namespace MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any value for a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter any value for b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Max(a, b)); // Maximum Value 

            Console.WriteLine(Math.Min(a, b)); // Minimum Value

            Console.WriteLine(Math.Sqrt(9));

            Console.WriteLine(Math.Abs(-5.7)); // Absolute Positive Value

            Console.WriteLine(Math.Round(45.8));

        }
    }
}
