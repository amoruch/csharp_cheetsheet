using System;

// exceptions

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            var v = Console.ReadLine();

            int a = -1;
            try {
                a = Convert.ToInt16(v);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("goida");
            }

            /* works as well
            try {
                a = Convert.ToInt16(v);
            } catch (Exception) {
                Console.WriteLine("aboba");
            } catch (FormatException) {...}...
            */

            Console.WriteLine(a);

            // java try-with-resources
            /*
            try {
                using (StreamReader reader = new StreamReader("file.txt")) {
                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (IOException ex) {
                Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}"); // amother interesting way of string formating
                throw; // отправляет ошибку дальше, обычно чтобы можно было получить полный лог ошибки
            }
            */

            Console.WriteLine($"goida {123}");

            // Console.ReadKey();
        }

        public static void ThrowFunction(int age) {
            throw new ArgumentOutOfRangeException(nameof(age), "aboba goida goooal");
        }
    }
}
