// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Mortgage Calculator (Bangladesh) ===");

        double salary = 0;
        double creditScore = 0;
        bool criminalRecord = false;

        while (true)
        {
            Console.Write("Enter your monthly salary: ");
            string input = (Console.ReadLine() ?? string.Empty).trim();
            ;
            if (double.TryParse(input, out salary))
                break;
            else
                Console.WriteLine("invalid input!please enter a numeric value.");
        }
        while (true)
        {
            Console.Write("Enter your credit score: ");
            string input = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(input, out creditScore))
                break;
            else
                Console.WriteLine("invalid input! please enter a numeric value.");
        }
        while (true)
        {
            Console.Write("Enter your criminal record: ");
            string input = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(input, out criminalRecord))
                break;
            else Console.WriteLine("Invalid input! please enter a boolian value.");
        }

        Console.Write("Enter loan amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (in %): ");
        double annualRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan period (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        double monthlyRate = annualRate / 100 / 12;
        int months = years * 12;

        double monthlyPayment = (principal * monthlyRate * Math.Pow(1 + monthlyRate, months))
                               / (Math.Pow(1 + monthlyRate, months) - 1);

        double totalPaid = monthlyPayment * months;
        double totalInterest = totalPaid - principal;

        // Set Bangladeshi Taka currency format
        CultureInfo bdCulture = new CultureInfo("bn-BD");

        Console.WriteLine($"\nMonthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");

    }
}
