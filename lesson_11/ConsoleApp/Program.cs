using System;

// classes
// works exactly like in java

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            // Console.WriteLine("did you miss me?"); im so fucking back

            // static -- one for the whole class(not objects of class)
            string emotion = Robot.emotion;

            Robot robot = new Robot(); // constructor is created by the default

            string name = robot.name; // non-static, had to create robot

            NewClass myClass = new NewClass(new byte[] { 0, 0, 0 });
            foreach (int a in myClass.getData()) {
                Console.WriteLine(a);
            }

            NewClass mySecondClass = new NewClass();
            foreach (int a in mySecondClass.getData()) {
                Console.WriteLine(a);
            }

            // myClass.data; -error, this shits private
            Console.WriteLine(String.Join(" | ", myClass.Data));

            NGRobot robot2 = new NGRobot("amoruch");
        }
    }

    class NewClass {
        // not very good practice to create new class in the same file
        private byte[] data;

        public NewClass() {
            this.data = new byte[] { 1, 1, 1 };
        }

        public NewClass(byte[] data) {
            this.data = data;
        }

        public byte[] getData() {
            return data;
        }

        public void setData(byte[] data) {
            this.data = data;
        }

        public static void printGay() {
            Console.WriteLine("gay");
            // static methods work only with static variables // duuuh 
        }

        // is there a different way to create getters and setters?
        // accessor (not a big fan, sry. its intersting, but meeh)
        public byte[] Data {
            get {
                return this.data;
            }
            set {
                this.data = value;
            }
        }

        // public byte[] Data { get; set; } -- by default, not necessary to write it
        // public byte[] Data { get; private set; } -- we can add accessibility?(cant change, only get)
    }
}
