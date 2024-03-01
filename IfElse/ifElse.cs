//Samuel Parente - C# programming exercises

using System;

namespace IfElse
{
    internal class ifElse
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            Console.WriteLine("Compare two numbers");

            //Get first number
            Console.WriteLine("Insert first number:");
            a = Convert.ToInt32(Console.ReadLine());

            //Get second number
            Console.WriteLine("Insert second number:");
            b = Convert.ToInt32(Console.ReadLine());

            //Compare numbers
            if (a == b)
            {
                Console.WriteLine("Numbers are equal.");
            }
            else if (a < b) {
                Console.WriteLine("First number is lower than second number.");
            }
            else if (a > b) { 
                Console.WriteLine("First number is bigger than second number.");
            }
            else
            {
                Console.WriteLine("Cannot compare the numbers.Check if you inserted correct numbers.");
            }

        }
    }
}
