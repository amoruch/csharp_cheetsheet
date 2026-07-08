using System;

// cycles

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("aboba");

            for (int i = 0; i < 5; i++) {
                Console.WriteLine(i);
                if (i > 2) {
                    break;
                } else {
                    continue;
                }
            }

            int a = 10;
            while (a > 0) a--;

            int b = 5;
            do {
                Console.WriteLine(b);
                b--;
            } while (b > 0);
        }
    }
}
