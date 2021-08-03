using System;

namespace ArithmeticOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for a:");
            int a = Convert.ToInt32(Console.ReadLine());
  
            Console.WriteLine("Enter value for b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition is: "+(a + b));
            Console.WriteLine("Subtraction is: "+(a - b));
            Console.WriteLine("Multiplication is: "+(a * b));
            Console.WriteLine("Division is: "+(a / b));

            Console.WriteLine("Modulus is: "+(a % b));

            Console.WriteLine("Pre-Increment is: "+(++a)); // a = 5 + 1, 6
            Console.WriteLine("Post-Increment is: "+(a++)); // a = 6
            Console.WriteLine("Pre-Decrement is: "+(--a)); // a = 7 - 1 = 6
            Console.WriteLine("Post-Decrement is: "+(a--)); // a = 6
            // a = 5
        }
    }
}
