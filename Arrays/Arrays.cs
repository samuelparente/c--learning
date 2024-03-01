//Samuel Parente - C# programming exercises

using System;

namespace Arrays
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            string[] cars = { "bmw", "mercedes", "vw", "ferrari", "porsche", "audi" };
            int[] numbers = { 0, 1, 2, 3, 4, 5 };
            int i = 0;

            for(i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]); 
            }

            for(i=0; i < numbers.Length; i++) 
            { 
                Console.WriteLine(numbers[i]); 
            }

        }
    }
}
