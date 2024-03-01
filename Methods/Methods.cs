//Samuel Parente - C# programming exercises

using System;

namespace Methods
{
    internal class Methods
    {
        static void Main(string[] args)
        {
            PrintMyName();
        }

        static void PrintMyName() {

            Console.WriteLine("Samuel Parente");
            Console.WriteLine(SumNumbers(10, 20));
        
        }

        static int SumNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
