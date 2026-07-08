using System;
using System.IO;

// files and strings

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            // strings 
            string s = "aboba"; // array of chars

            Console.WriteLine(s[2]);

            string people = "a, b, o";
            Console.WriteLine(String.Join("/", people.Split(", ")));

            Console.WriteLine("   3   0   ".Trim());
            Console.WriteLine("1234".Substring(2, 2)); // from there and how many

            // ToUpper()
            // ToLower()
            // ....

            // files
            using (FileStream stream = new FileStream("text.txt", FileMode.OpenOrCreate)) {
                byte[] array = System.Text.Encoding.Default.GetBytes(people);

                stream.Write(array, 0, array.Length);
            }

            using (FileStream stream = File.OpenRead("text.txt")) {
                byte[] array = new byte[stream.Length];

                // stream.Read(array, 0, array.Length); - sad problem
                stream.ReadExactly(array, 0, array.Length);

                string text = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(text);
            }
        }
    }
}
