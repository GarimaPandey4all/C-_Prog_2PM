using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //String: Store Text = Collection of Characters: "Hello"

            string name = "Brain Mentors";

            Console.WriteLine(name);
            Console.WriteLine(name.Length); // Length = String Length
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());

            string firstName = "Ram";
            string lastName = "Kumar";

            //string fullName = firstName + lastName; // + : Concatenation / Joining

            //string fullName = string.Concat(firstName, lastName);

            //String Interpolation

            string fullName = $"full name is: {firstName} {lastName}";

            Console.WriteLine(fullName);

            string text = "Hello";

            Console.WriteLine(text[4]); // [] - square bracket/subscript operator // 0 to 4 index numbers

            Console.WriteLine(text.IndexOf("o"));

            string txt = "Ram Kumar";

            int pos = txt.IndexOf("K");

            string subString = txt.Substring(pos);

            Console.WriteLine(subString);

            string a = "10", b = "20";

            Console.WriteLine(a + b);
        }
    }
}
