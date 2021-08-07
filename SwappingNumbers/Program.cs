using System;

namespace SwappingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //a = 10, b = 20
            //a = 20 b = 10
            /*
            Swapping has two types:
            1. Using third variable
            2. Without using third variable
            */

            //1. Using third variable
            /*
            int a = 5, b = 7;

            Console.WriteLine("{0} and {1}", a, b);

            int temp = a; // 5
            a = b; //  a = 7
            b = temp; // b = 5

            Console.WriteLine("{0} and {1}", a, b);*/

            //2. Without using third variable

            int a = 5, b = 10;

            //1st way
            /*
            Console.WriteLine("{0} and {1}", a, b);

            a = a + b; // a = 15
            b = a - b; // 15 - 10 = 5 = b
            a = a - b; // 15 - 5 = 10 = a

            Console.WriteLine("{0} and {1}", a, b);
            */

            //2nd Way
            /*
            Console.WriteLine("{0} and {1}", a, b);

            a = a * b; // a = 50
            b = a / b; // 50 / 10 = 5 = b
            a = a / b; // 50 / 5 = 10 = a

            Console.WriteLine("{0} and {1}", a, b);
            */

            //3rd Way

            Console.WriteLine("{0} and {1}", a, b);

            // a = 5 =  0101
            // b = 10 = 1010 ^
            //            1111 = 15 ^
            //            0101 = 5 ^
            //            1010 = 10

            a = a ^ b; // a = 15
            b = a ^ b; // 15 ^ 10 = 5 = b
            a = a ^ b; // 15 ^ 5 = 10

            Console.WriteLine("{0} and {1}", a, b);

        }
    }
}
