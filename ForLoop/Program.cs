using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter any number to be print the table:");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            }
        }
    }
}
