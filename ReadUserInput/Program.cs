using System;

namespace ReadUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine(); // It is used to take user input at runtime.

            Console.WriteLine("Your name is: "+name);

            Console.WriteLine("Enter your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: "+age);
        }
    }
}
