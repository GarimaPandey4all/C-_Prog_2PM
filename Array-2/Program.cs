using System;
using System.Linq;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {20, 10, 30, 40, 50};

            Array.Sort(arr); // Array Sort: ascending order

            // for each loop - array read
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine();

            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }

            Console.WriteLine("Maximum Value is: "+ arr.Max());
            Console.WriteLine("Minimum Value is: "+ arr.Min());
            Console.WriteLine("Addition is: "+ arr.Sum());
        }
    }
}
