using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());

            do {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
                i++;
            }while(i <= 10);
        }
    }
}
