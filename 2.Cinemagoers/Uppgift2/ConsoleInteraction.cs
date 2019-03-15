using System;
using System.Collections.Generic;

namespace Uppgift2
{
    public class ConsoleInteraction
    {

        public static ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static void Write(string message)
        {
            Console.Write(message);
        }

        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public static void ShowPrompt()
        {
            WriteLine("\nAnge Menyval(0,1,2,3):");
        }

        public static void ShowExiting()
        {
            WriteLine("\nAvslutar");
        }

        public static void ShowHitAnyKeyToExit()
        {
            WriteLine("Hit any key to exit...");
            ReadKey();
        }

        public static void WriteLines(List<string> messages)
        {
            foreach(var message in messages)
            {
                WriteLine(message);
            }
        }

    }
}
