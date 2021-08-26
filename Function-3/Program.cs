using System;

namespace Function_3
{
    class Program
    {
         // 3. Function without arguments/parameters and with return type

         static int Sum()
         {
             int a, b;

             Console.WriteLine("Enter value for a and b:");
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());

             return (a + b);
         }

        static void Main(string[] args)
        {
            int result = Sum();

            Console.WriteLine("Addition is: "+result);
        }
    }
}
