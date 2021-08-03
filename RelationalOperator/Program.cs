using System;

namespace RelationalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter value for a:");
            int a = Convert.ToInt32(Console.ReadLine());
  
            Console.WriteLine("Enter value for b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Equal to: "+(a == b));
            Console.WriteLine("Not Equal to: "+(a != b));
            Console.WriteLine("Greater than and Equal to: "+(a >= b));
            Console.WriteLine("Less than and Equal to: "+(a <= b));
            Console.WriteLine("Greater than: "+(a > b));
            Console.WriteLine("Less than: "+(a < b));
        }
    }
}
