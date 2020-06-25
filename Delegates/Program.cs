using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Manju", "Puchhi", "Chitte", "Dummy", "Gum", "sis", "Kanadagal" };
            List<string> lessThanFiveChar = NamesFilter(names, LessThanFive);
            List<string> moreThanFive = NamesFilter(names,MoreThanFive);
            List<string> equalToFive = NamesFilter(names, EqualToFive);
            Console.WriteLine(string.Join(", ", lessThanFiveChar));
            Console.WriteLine(string.Join(", ", moreThanFive));
            Console.WriteLine(string.Join(", ", equalToFive));
            Console.ReadLine();
        }

        delegate bool Filters(string item);
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

        private static List<string> NamesFilter(string[] names , Filters filters)
        {
            List<string> result = new List<string>();
            foreach(var name in names)
            {
                if(filters(name))
                {
                    result.Add(name);
                }
            }
            return result;
        }
    }
}
