using System;
using ClassLibrary;

// LINQ - Language Integrated Query(kinda like SQL: where, select etc.)
using System.Linq;

// this program is an example of advanced c# coding techiques and features, which will be discussed later with more detailes

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            decimal totalSalaries = 0;

            List<SomeInterface> list = new List<SomeInterface>();

            MyFunction(list);

            foreach (SomeInterface element in list) {
                totalSalaries += element.Salary;
            }

            Console.WriteLine(totalSalaries);

            // or a better realization

            Console.WriteLine(list.Sum(e => e.Salary)); // Lambda expression

            // Func<string, string> selector = str => str.Upper(); -- just like in java i guess
        }

        public static void MyFunction(List<SomeInterface> list) {
            /*
            SomeInterface object1 = new MyClass1 {
                Id = 1,
                FirstName = "aboba",
                LastName = "abobooba",
                Salary = 2
            };

            list.Add(object1);

            SomeInterface object2 = new MyClass2 {
                Id = 2,
                FirstName = "ferma",
                LastName = "goida",
                Salary = 999
            };

            list.Add(object2);
            */

            // using Factory pattern
            SomeInterface object1 = ClassFactory.GetMyClass(ClassType.MyClass1, 1, "aboba", "abobooba", 2);
            list.Add(object1);

            SomeInterface object2 = ClassFactory.GetMyClass(ClassType.MyClass2, 2, "ferma", "goida", 999);
            list.Add(object2);
        }
    }

    public enum ClassType {
        MyClass1,
        MyClass2
    }

    public class MyClass1 : AbstractClass {
        public override decimal Salary { get => base.Salary * 1.02m; }
    }

    public class MyClass2 : AbstractClass {
        public override decimal Salary { get => base.Salary * 2.0m; }
    }

    public static class ClassFactory {
        public static SomeInterface GetMyClass(ClassType classType, int id, string firstName, string lastName, decimal salary) {
            SomeInterface myClass;

            switch (classType) {
                case ClassType.MyClass1:
                    myClass = new MyClass1 { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                    break;
                case ClassType.MyClass2:
                    myClass = new MyClass2 { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(classType), $"Unsupported class type: {classType}");
            }

            return myClass;
        }
    }
}
