using System;

namespace SumofDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());

            int temp = n;

            while(n > 0)
            {
                // n = 121 = 4
                int remainder = n % 10;  // 1
                sum = sum + remainder;  // 0 + 1 = 1, 1 + 2  = 3, 3 + 1 = 4
                n = n / 10;  // 12
            }

            Console.WriteLine("Sum of Digits: "+sum);

        }
    }
}
