using System;

// classes: abstract

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Animal dog = new Dog();

            // Animal animal = new Animal(); -- error, abstract doesnt have constructor

            List<Animal> animals = new List<Animal>();
            // working with list of dogs, cats, horses via some kind of interface(Animal)
        }
    }

    // Абстрактный класс
    abstract class Animal {
        // Обычный метод с реализацией
        public void Sleep() {
            Console.WriteLine("Животное спит");
        }

        // Абстрактный метод (без реализации)
        public abstract void MakeSound();
    }

    // Наследник обязан реализовать абстрактный метод
    class Dog : Animal {
        public override void MakeSound() {
            Console.WriteLine("Гав-гав!");
        }
    }
}
