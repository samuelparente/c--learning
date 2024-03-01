//Samuel Parente - C# programming exercises

using System;

namespace Loops
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("FOR LOOP");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("WHILE LOOP");

            i = 0;

            while (i < 10){
                Console.WriteLine(i);
                i++;
            } 

        }
    }
}
