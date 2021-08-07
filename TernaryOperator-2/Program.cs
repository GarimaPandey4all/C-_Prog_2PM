using System;

namespace TernaryOperator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 70, b = 50, c = 30;

           String result =  (a > b && a > c) ? "A is Greater" : ((b > c) ? "B is Greater" : "C is Greater");

           Console.WriteLine(result);
        }
    }
}
