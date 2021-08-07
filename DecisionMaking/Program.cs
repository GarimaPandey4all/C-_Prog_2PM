using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Decison Making/ Conditional Statements
                1. If-else
                2. If-else if-else
                shorthand: ternary/conditional operator
                3. switch
            */

            int a = 50 , b = 40;
            // c = 10;

            //Ternary = 3 Operator

            //Condition ? true : false;
            String result = (a > b) ? "A is Greater" : "B is Greater";

            Console.WriteLine(result);

            /*
            if(a > b && a > c)
            {
                Console.WriteLine("A is greater");
            }
            else if(b > c)
            {
                Console.WriteLine("B is greater");
            }
            else {
                Console.WriteLine("C is greater");
            }*/

            /*
            if(a > b)
            {
                Console.WriteLine("A is greater");
            }
            else {
                Console.WriteLine("B is greater");
            }*/

        }
    }
}
