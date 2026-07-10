using System;

// classes: is, as

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("is and as");

            List<Element> list = new List<Element>();

            list.Add(new Element("1"));
            list.Add(new Element("2"));

            foreach (Element elem in list) {
                Console.WriteLine(elem);
            }

            List<Ilement> lest = new List<Ilement>();

            lest.Add(new Ilement("1"));
            lest.Add(new Ilement("2"));

            foreach (Ilement elem in lest) {
                Element e = elem as Element;
                Console.WriteLine(e); // maybe not a very proper example, but you got the point
            }

            if (lest[0] is Element) {
                Console.WriteLine("is example:" + lest[0] + " is " + typeof(Element));
            }
        }
    }

    class Element {
        public string info = "aboba";

        public Element(string name) {
            Name = name;
        }

        public string Name { get; private set; }

        public override string ToString() {
            return Name + ":" + info;
        }
    }

    class Ilement : Element {
        public Ilement() : base("Ilement") {
            More = "idk";
            Console.WriteLine("cool element");
        }

        public Ilement(string more) : this() {
            More = more;
        }

        public string More { get; set; }
    }
}
