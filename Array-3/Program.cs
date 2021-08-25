using System;

namespace Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; // array declare

            Console.WriteLine("Enter values in an Array:");
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Values in an Array are:");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
            }

        } 
    }
}
