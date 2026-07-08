using System;

// if, cases

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            int a;

            a = int.Parse(Console.ReadLine());

            if (a == 1) {
                Console.WriteLine("a = 1");
            } else if (a > 1) {
                Console.WriteLine("a > 1");
            } else if (a < 1) {
                Console.WriteLine("a < 1");
            }

            bool b = false;

            if ((b || !b) && (a > 1)) {
                Console.WriteLine("aboba");
            }

            // should be careful with floats and strings

            switch (a) {
                case 1:
                    Console.WriteLine(":1");
                    break;
                case 0:
                    Console.WriteLine("goal");
                    break;
                default:
                    Console.WriteLine("not goida");
                    break;
            }
        }
    }
}
