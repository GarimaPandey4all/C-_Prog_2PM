using System;

namespace Enum
{
    class Program
    {
        enum week {
                Monday = 1, // 0
                Tuesdday, // 1
                Wednesday, // 2
                Thursday, // 3
                Friday, // 4
                Saturday, // 5
                Sunday // 6
        }  

        static void Main(string[] args)
        {
            //Enum: Enumeration is a special class in C#, the represents a group of contants.
            // week today = week.Saturday;
            // Console.WriteLine(today);

            int today = (int)week.Friday;
            Console.WriteLine(today);
        }
    }
}
