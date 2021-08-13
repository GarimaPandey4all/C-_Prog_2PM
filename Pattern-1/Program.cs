using System;

namespace Pattern_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for(i = 1; i <= 5; i++) // rows // outer // 5
            {
                for(j = 1; j <= 5; j++) // cols // inner // 5 * 5 = 25
                {
                    //Console.Write("*");
                    //Console.Write(i);
                    Console.Write(j);
                }

                Console.WriteLine(); // new line, Enter
            }
            
        }
    }
}
