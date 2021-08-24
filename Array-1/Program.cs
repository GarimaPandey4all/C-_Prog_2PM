using System;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array: It is used to store multiple values in a single variable.
            // It is collection of similar types of data/values.
            // It is also called homogeneous mixture.

            // [] - Array's Symbol

            int[] lists = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; // array's size = 5, 10

            Console.WriteLine(lists[2]);
            Console.WriteLine(lists[0]);

            Console.WriteLine(lists.Length); // 10
            
            for(int i = 0; i < lists.Length; i++)
            {
                Console.Write(lists[i]+" ");
            }
        }
    }
}
