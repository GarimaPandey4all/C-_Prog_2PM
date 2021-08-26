using System;

namespace Function_2
{
    class Program
    {
        // 2. Function with arguments/parameters and without return type

        static void Sum(int a, int b) // Function Parameters / Formal Arguments
        {
            Console.WriteLine("Addition is: "+(a + b));
        }

        static void Main(string[] args)
        {
            Sum(10, 20); // Function Arguments / Actual Arguments
            Sum(40, 60);
        }
    }
}
