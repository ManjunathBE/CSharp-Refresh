using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        public delegate bool CheckLengthOfString(string message);
        static void Main(string[] args)
        {
            CheckLengthOfString d = LessThanFive;
            d += MoreThanFive;
            d += EqualToFive;

            //List<bool> results = new List<bool>();
            //foreach(var del in d.GetInvocationList())
            //{
            //    results.Add((bool)del.DynamicInvoke("Message"));
            //}

            List<bool> results = d.GetInvocationList().Select(del => (bool)del.DynamicInvoke("Message")).ToList();

            Console.WriteLine(string.Join(", ", results)); 
            Console.ReadLine();
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

         
    }
}
