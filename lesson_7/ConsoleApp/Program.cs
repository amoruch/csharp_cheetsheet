using System;

using System.Collections.Generic;

// arrays

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {

            // arrays and multi-dim arrays

            byte[] aboba = new byte[4];

            aboba[0] = 1;
            aboba[1] = 2;
            aboba[3] = 4;

            for (int i = 0; i < 4; i++) {
                Console.WriteLine(aboba[i]);
            }

            string[] names = new string[] { "aboba", "goida" };

            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
            }

            Random random = new Random();

            int L = 10;

            short[] numbers = new short[L];
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = Convert.ToInt16(random.Next(5, 15));
            }

            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine(numbers[i]);
            }

            char[,] symbols = new char[2, 3];
            for (int i = 0; i < 6; i++) {
                symbols[i / 3, i % 3] = Convert.ToChar(i + 'a');
            }

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write(symbols[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] nums = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            // foreach
            Console.WriteLine("\nlesson 9:");
            Console.WriteLine("chaper 1: foreach");

            short[] fornums = new short[] { 1, 2, 3, 4 };

            foreach (short a in fornums) {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            Console.WriteLine("multi-dim foreach");
            foreach (short a in nums) {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            // generic (list)
            Console.WriteLine("dynamic list");

            List<int> list = new List<int>() {
                1, 2, 3
            };

            foreach (int i in list) Console.Write(i + " ");
            Console.WriteLine();

            list.Add(4);
            list.Remove(1);
            list.RemoveAt(0);

            foreach (int i in list) Console.Write(i + " ");
            Console.WriteLine();

            // list.Sort();
            // list.Reverse();
            // ...
        }
    }
}
