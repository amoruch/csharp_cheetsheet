using System;

// enums

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Weapon weapon = Weapon.aboba;

            Console.WriteLine((int)weapon);

            // parsing

            string input = "aboba";
            if (Enum.TryParse<Weapon>(input, out Weapon result)) { // hard syntaxis
                Console.WriteLine($"Успешно распарсено: {result}");
            }

            string[] names = Enum.GetNames<Weapon>();
            Weapon[] values = Enum.GetValues<Weapon>(); // all elements
            foreach (Weapon w in values) {
                Console.WriteLine(w);
            }
        }
    }

    enum Weapon {
        aboba, sword, spear // toString - type, (int) - 0, 1, 2
    }

    enum HttpStatusCode {
        Ok = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404,
        InternalServerError = 500
    }

    enum GameDifficulty : byte {
        Easy,
        Medium,
        Hard
    }
}
