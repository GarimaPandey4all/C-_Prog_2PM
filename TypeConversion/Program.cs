using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit casting
            int a = 10;
            //float c = 56.74f;
            double d = a; // automatically;

            Console.WriteLine(a);
            Console.WriteLine(d);

            //Explicit casting
            double f = 35.68;
            int b = (int)f; // Manually

            Console.WriteLine(f);
            Console.WriteLine(b);
        }
    }
}
