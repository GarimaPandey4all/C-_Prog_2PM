using System;

namespace Function_4
{
    class Program
    {
        // 4. Function with arguments/parameters and with return type

        static int Sum(int a, int b)
        {
            return (a + b);
        }

        static void Main(string[] args)
        {
            int result = Sum(10, 20);
            Console.WriteLine("Addition is: "+result);
        }
    }
}
