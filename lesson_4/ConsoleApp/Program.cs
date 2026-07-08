using System;

// meth

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter number: ");

            double variable = double.Parse(Console.ReadLine());

            double result = (variable + 10d - 10) * 2 / 10 % 1.23;

            result += result;
            result *= result;
            // ...

            result++;
            result--;
            --result;
            ++result;

            System.Console.WriteLine(Math.PI); // no need for using Math;
            Console.WriteLine(Math.Abs(-10));
            // Math.Ceiling(4.11f) = 5;
            // Math.Floor(4.99f) = 4;
            // Math.Round(4.5f) = 5; ?
            // sin cos square pow min max  ...

            Console.WriteLine("aboba {0} aboba {1} aboba", 1, 2);

            Console.ReadKey();
        }
    }
}