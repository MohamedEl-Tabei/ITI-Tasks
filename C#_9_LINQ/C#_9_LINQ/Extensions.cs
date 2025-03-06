using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__9_LINQ
{
    internal static class Extensions
    {
        public static void Print(this IEnumerable values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
        public static void Print(this IEnumerable<string> values)
        {
            foreach (var value in values)
            {
                Console.Write($"{value}\t");
            }
            Console.WriteLine();
        }
        public static void Print(this IEnumerable<int> values)
        {
            foreach (var value in values)
            {
                Console.Write($"{value}\t");
            }
            Console.WriteLine();
        }
        public static void Print(this IEnumerable<IEnumerable> collections)
        {
            foreach (var collection in collections)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
