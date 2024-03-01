//Samuel Parente - C# programming exercises

using System;

namespace UserInput
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Insert your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hi there, " + name);
        }
    }
}
