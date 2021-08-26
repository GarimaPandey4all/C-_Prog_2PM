using System;

namespace Function_1
{
    class Program
    {   
        // 1. Function without arguments/parameters and without return type

        // void / int / char/ float - return type, void - empty or null
        // function definition/initialization
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                //function calling
                HelloWorld();
            }
            
        }
    }
}
