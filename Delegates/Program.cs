using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Manju", "Puchhi", "Chitte", "Dummy", "Gum", "sis", "Kanadagal" };

            Func<string[], Func<string, bool>, List<string>> extractString = (array, filter) =>
             {
                 List<string> result = new List<string>();
                 foreach (var item in array)
                 {
                     if (filter(item))
                     {
                         result.Add(item);
                     }
                 }
                 return result;
             };

            Func<string, bool> lessThanFive = x => x.Length < 5;
            Func<string, bool> moreThanFive = x => x.Length > 2;

            List<string> namesLessThanFiveChars = extractString(names, lessThanFive);
            List<string> namesMoreThanFiveChars = extractString(names, moreThanFive);

            Console.WriteLine(string.Join(", ", namesLessThanFiveChars));
            Console.WriteLine(string.Join(", ", namesMoreThanFiveChars));

            Console.ReadLine();
        }

        

    }
}
