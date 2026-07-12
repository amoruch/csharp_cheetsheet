using System;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("aboba");
        }
    }

    interface IRun {
        float speed { get; set; }

        void Run(); // methods description: type, name and args
    }

    class Person : IRun {
        public float speed { get; set; }

        public void Run() {
            Console.WriteLine("running");
        }
    }

    // class can implement multiple interfaces

    interface IJump {
        float y { get; set; }

        void jump();
    }

    class Athlet : IRun, IJump {
        public float speed { get; set; }
        public float y { get; set; }

        public void jump() {
            Console.WriteLine("jumping");
        }

        public void Run() {
            Console.WriteLine("running");
        }
    }
}
