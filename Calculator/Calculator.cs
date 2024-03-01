//Samuel Parente - C# programming exercises

using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            while (true)
            {
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Addition();
                        break;
                    case "2":
                        Subtraction();
                        break;
                    case "3":
                        Multiplication();
                        break;
                    case "4":
                        Division();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void Addition()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 + num2;
            Console.WriteLine($"Result: {result}");
        }

        static void Subtraction()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 - num2;
            Console.WriteLine($"Result: {result}");
        }

        static void Multiplication()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 * num2;
            Console.WriteLine($"Result: {result}");
        }

        static void Division()
        {
            Console.Write("Enter the dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                double result = dividend / divisor;
                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
