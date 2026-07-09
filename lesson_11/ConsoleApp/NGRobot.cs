using System;

// inheritance
// only from one, early versions could inherit from many classes
// inherits everything from his parent and can add or rewrite new methods and fields.

namespace ConsoleApp {
    class NGRobot : Robot {
        public string parent = "ozymandias";

        public NGRobot(string name) : base(name) {
            Console.WriteLine($"executing: Robot('{name}')");
            // base(name) -- is like calling super(name), but in c#
            // base.someMethod(params); -- also works
        }

        // private -- only this class
        // protected -- only this class AND its inheritance
        // (non) -- package access
        // public -- everyone
        // just like in java
    }
}
