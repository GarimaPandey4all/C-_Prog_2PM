using System;

namespace Pattern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char i, j;

            for(i = 'A'; i <= 'E'; i++) 
            {
                for(j = 'A'; j <= 'E'; j++) 
                {
                    Console.Write(i);
                    //Console.Write(j);
                }

                Console.WriteLine(); 
            }
        }
    }
}
