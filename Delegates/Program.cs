using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        public delegate bool CheckLengthOfString(string message);
        public delegate int GetLengths(string message);


        static void Main(string[] args)
        {
            //Func<string, bool> lessThanFive = LessThanFive;
            Func<string, bool> lessThanFive = x => x.Length < 5;

            Action<string> printer = Print;
            printer += PrintTwice;
            printer("Message");

            string[] names = { "Manju", "Puchhi", "Chitte", "Dummy", "Gum", "sis", "Kanadagal" };
            List<string> lessThanFiveChar = NamesFilter(names, item => item.Length > 5);
            //List<string> moreThanFive = NamesFilter(names, item => item.Length < 5);
            List<string> equalToFive = NamesFilter(names, item => item.Length == 5);

            //List<string> lessThanFiveChar = NamesFilter(names, LessThanFive);
            List<string> moreThanFive = NamesFilter(names,MoreThanFive);
            //List<string> equalToFive = NamesFilter(names, EqualToFive);
            Console.WriteLine(string.Join(", ", lessThanFiveChar));
            Console.WriteLine(string.Join(", ", moreThanFive));
            Console.WriteLine(string.Join(", ", equalToFive));
            Console.ReadLine();

            Console.ReadLine();
        }

        public static List<T> GottaCatchEmAll<T>(Delegate del, object parameter = null)
        {
            List<T> result = del.GetInvocationList()
                                .Select(d => (T)d.DynamicInvoke(parameter))
                                .ToList();
            return result;
        }
        public static bool MoreThanFive(string name)
        {
            return name.Length > 5;
        }

        public static bool LessThanFive(string name)
        {
            return name.Length < 5;
        }

        public static bool EqualToFive(string name)
        {
            return name.Length == 5;
        }

        private static List<string> NamesFilter(string[] names, Func<string,bool> filters)
        {
            List<string> result = new List<string>();
            foreach (var name in names)
            {
                if (filters(name))
                {
                    result.Add(name);
                }
            }
            return result;
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
