using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Types: It is used to define the data

            // 1 byte = 8 bits, 0, 1

            int a = 10;
            float b = 45.67f; // decimal/float values - float (4 bytes - 32 bits) and double (8 bytes - 64 bits)
            double c = 67.78;
            char ch = 'F';
            string name = "Ram";
            bool state = true; // bool - boolean data type, on-true, off-false

            /*
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(ch);
            Console.WriteLine(name);
            Console.WriteLine(state);
            */

            Console.WriteLine("A = {0} B = {1} Ch = {3} name = {4} State = {5} C = {2}", a, b, c, ch, name, state); 
            //a = 0, b = 1, c = 2, ch = 3, name = 4, state = 5

        }
    }
}
