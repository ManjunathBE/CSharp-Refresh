using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        public delegate void Printer(string message);
        static void Main(string[] args)
        {
            Printer p = Print;
           
            p += Print;
            p += PrintTwice;

            //or 

            p("hello message");
            Console.ReadLine();
        }

        public static void PrintTwice(string message)
        {
            Console.WriteLine(message + "1");
            Console.WriteLine(message + "1");
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);

        }
    }
}
