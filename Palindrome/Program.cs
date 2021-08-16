using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Enter any number that you want to check the given number is palindrome or not:");
            int n = Convert.ToInt32(Console.ReadLine());

            int temp = n;

            while(n > 0)
            {
                // n = 121
                int remainder = n % 10; // 121 % 10 = 1, 12 % 10 = 2, 1 % 10 = 1
                sum = sum * 10 + remainder; // 0 * 10 + 1 = 1, 1 * 10 + 2 = 12, 12 * 10 + 1 = 121
                n = n / 10; // 121 / 10 = 12, 12 / 10 = 1, 1 / 10 = 0
            }

            n = temp;

            if(sum == n)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else {
                Console.WriteLine("Number is not Palindrome");
            }
        }
    }
}
