using System;

namespace LogicalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter value for a:");
            int a = Convert.ToInt32(Console.ReadLine());
  
            Console.WriteLine("Enter value for b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Logical AND Operator: "+(a > b && b < 10));
            Console.WriteLine("Logical OR Operator: "+(a > b || b < 10));
            Console.WriteLine("Logical NOT Operator: "+(!(a > b && b < 10))); // !, true --> false, false --> true
        }
    }
}
