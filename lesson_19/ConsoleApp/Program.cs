using System;

// delegates: introduction

namespace ConsoleApp {
    // delegate void LogDel(string text);
    class Program {
        // same signature as the referencing method
        delegate void LogDel(string text);
        static void Main(string[] args) {
            Log log = new Log();

            // A delegate is a type that references a method.
            LogDel logDel = new LogDel(log.LogTextToScreen);
            // LogDel logDel = LogTextToScreen

            logDel("text");
            // logDel.Invoke("text");

            LogDel logDelFile = new LogDel(log.TextToFile);

            logDelFile("file");

            // LogDel LogTextToScreenDel, LogTextToFileDel;
            // LogTextToScreenDel = new LogDel(log.LogTextToScreen);
            // LogTextToFileDel = new LogDel(log.TextToFile);

            // multi delegate
            LogDel multiLogDel = logDel + logDelFile;
            multiLogDel("multi");

            LogText(multiLogDel, "static");

            Console.ReadKey();
        }

        static void LogText(LogDel logDel, string text) {
            logDel(text);
        }
    }

    public class Log {
        public void LogTextToScreen(string text) {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        public void TextToFile(string text) {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true)) {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
}
