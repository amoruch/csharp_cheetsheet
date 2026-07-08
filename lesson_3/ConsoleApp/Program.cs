using System;
using System.Data;

// variables and types

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            // integer
            int a; // declaration
            a = -10; // <= 2147483647, 4 byte
            Console.WriteLine("integer " + a); // auto convertation to string? a.toString()?

            // unsigned integer
            uint us = 10; // <= 4294967295, 4 byte positive
            Console.WriteLine("unsigned integer " + us);

            byte b = 1; // <= 255 , less memory, 1 byte lol, 8 bit
            Console.WriteLine("byte " + b);

            short s = 32767; // limit, 2 byte
            Console.WriteLine("byte " + s);

            long l = 9223372036854775807; // limit, 8 bytes?
            Console.WriteLine("long " + l);

            ulong ul = 18446744073709551615; // limit, 8 bytes? positive
            Console.WriteLine("ulong " + ul);

            float f = 1.6f; // without f its double, cant convert to float correctly kinda
            Console.WriteLine("float " + f);

            double d = 32.12; // bigger better stronger (32.12d same)
            Console.WriteLine("double " + d);

            string str = "name"; // list of characters
            Console.WriteLine("string " + str);

            char c = 'A'; // one symbol, character, key
            Console.WriteLine("Character " + c);

            bool isGay = false;
            Console.WriteLine("boolean " + isGay);

            // multiple declaration
            int n1, n2 = 0;
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + n2);

            Console.ReadKey();

            dynamic dyn;
            dyn = 0;
            Console.WriteLine(dyn == n1);
            dyn = "name";
            Console.WriteLine(dyn.ToUpper());
        }
    }
}
