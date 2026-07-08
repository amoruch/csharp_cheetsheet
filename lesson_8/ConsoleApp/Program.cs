using System;

// functions

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Aboba());
            Console.WriteLine(Aboba("aboba"));

            byte[] array = new byte[] { 1, 2, 3 };

            Console.WriteLine(Summa(array));
        }

        /**
            public - everyone in this namespace(or program?) can access it.
            static - one for every object of class(java alike)
            string - return type(void for nothing)
            args - duuh
        */
        public static string Aboba() {
            return "string";
        }

        public static string Aboba(string arg) {
            return arg + arg;
        }

        public static int Summa(byte[] array) {
            int res = 0;
            foreach (int elem in array) {
                res += elem;
            }
            return res;
        }
    }
}
