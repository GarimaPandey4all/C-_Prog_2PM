using System;

namespace Enum_2
{
    class Program
    { // RGB Format
        enum colors {
            red,  // 0
            green, // 1
            blue // 2
        }

        static void Main(string[] args)
        {
           // colors myColor = colors.red;
           colors myColor = colors.blue;

            switch(myColor)
            {
                case colors.red:
                Console.WriteLine("Red Color");
                break;

                case colors.green:
                Console.WriteLine("Green Color");
                break;

                case colors.blue:
                Console.WriteLine("Blue Color");
                break;

                default:
                Console.WriteLine("Invalid Color");
                break;
            }
        }
    }
}
