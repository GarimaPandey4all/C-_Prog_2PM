using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            //while(true) // infinite
            int i = 1;
            while(i <= 2)
            {
                
                Console.WriteLine("Press 1. Addition");
                Console.WriteLine("Press 2. Subtraction");
                Console.WriteLine("Press 3. Division");
                Console.WriteLine("Press 4. Multiplication");
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch(choice)
                {
                    case 1:

                    Console.WriteLine("Enter value for number 1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                        
                    Console.WriteLine("Enter value for number 2");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Addition is: "+(num1 + num2));

                    break;

                    case 2:
                    Console.WriteLine("Enter value for number 1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter value for number 2");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Subtraction is: "+(num1 - num2));

                    break;

                    case 3:
                    Console.WriteLine("Enter value for number 1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter value for number 2");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Division is: "+(num1 / num2));

                    break;

                    case 4:
                    Console.WriteLine("Enter value for number 1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter value for number 2");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Multiplication is: "+(num1 * num2));

                    break;

                    default:
                    Console.WriteLine("Invalid Choice");
                    break;
                }
                i++; // 1--> 2
            }
        }
    }
}
