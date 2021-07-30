using System;

namespace TypeConversion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicitly - 2 Conversion
            //Type Conversion Methods/Built-in Methods

            int a = 10;
            double d = 56.78;
            bool state = true;

            Console.WriteLine(Convert.ToString(a)); // int to String
            Console.WriteLine(Convert.ToDouble(a)); // int to double
            Console.WriteLine(Convert.ToInt32(d)); // double to int
            Console.WriteLine(Convert.ToString(state)); // bool into string

           // int - 4 bytes = 32 bits Convert.ToInt32() // int
           // long - 8 bytes = 64 bits Convert.ToInt64() // long

        }
    }
}
