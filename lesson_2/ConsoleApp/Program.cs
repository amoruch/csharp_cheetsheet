using System;

// basic architecture and working with console

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = Console.ReadLine();
            Console.WriteLine(a);

            Console.WriteLine("Programm finished. Press any key to exit.");
            Console.ReadKey(); // reads one symbol
        }
    }
}
