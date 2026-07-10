using System;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            MyClass c = new MyClass();
            c.Method();

            ChildClass cc = new ChildClass();
            cc.Method();
        }
    }

    class MyClass {
        public virtual void Method() {
            Console.WriteLine("do stuff");
        }
    }

    class ChildClass : MyClass {
        public override void Method() {
            Console.WriteLine("do other stuff");
        }
    }
}
