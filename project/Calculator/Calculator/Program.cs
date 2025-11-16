// See https://aka.ms/new-console-template for more information
using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Calculating;
            do
            {
                Console.WriteLine("Select a calculaton method");
                Console.WriteLine("1.Addition(+)");
                Console.WriteLine("2.Subtraction(-)");
                Console.WriteLine("3.Multipication(*)");
                Console.WriteLine("4.Division(/)");
                Console.WriteLine("5.Exit");

                String choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = num1 + num2;

                        Console.WriteLine($"Result:{num1} + {num2} = {result} ");
                        break;

                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error:Divison by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("invalid!please select 1-5.");
                        break;

                }
                Console.WriteLine($"Result: {result}");
                Calculating = true;

            } while(Calculating);
        }
    }
}
