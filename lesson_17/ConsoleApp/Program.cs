using System;

// struct

namespace ConsoleApp {
    struct Book {
        private string title, author;

        private int pages;

        public void setValues(string title, string author, int pages) {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public void printValues() {
            Console.WriteLine($"{title}, {author}, {pages}");
        }
    }

    public struct Point {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) {
            X = x;
            Y = y;
        }

        public void Display() => Console.WriteLine($"X: {X}, Y: {Y}"); // lambda function ?
    }

    class Program {
        static void Main(string[] args) {
            Book book = new Book();
            book.setValues("1", "2", 3);
            book.printValues();

            // main diffs between structures and classes:
            /*
             struct is value type
             stored in stack (fast access)
             stores variables, not links
             cant inherit
             cant be null
             */

            /*
             Point p1 = p2; -- full copy, changing one wont change another
             all structures are children of System.ValueType
             */

            /*
             readonly struct -- immutable struct(struct is easier for processor to work with)
             ref struct -- can be stored only on stack???
             record struct -- wrapper of struct, basically add cool methoods i guess
             */

            /* recomendations
             struct should represents a single simple light-weighted object(up to 16 bytes)
             immutable recommended and not to box/unbox oftenn 
             */

            /*
             can use modificators like in, ref & out for memory savings?  
             */
        }
    }
}
