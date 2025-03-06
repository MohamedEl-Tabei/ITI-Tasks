using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal static class Extensions
    {
        public static void Print(this IEnumerable<int> numbers,string txt)
        {
            Console.WriteLine(txt);
            foreach (int number in numbers)
            {
                Console.Write($"{number}\t");
            }
            Console.WriteLine("\n---------------------------------------------------------------\n\n");
        }
        public static void Print<T>(this IEnumerable<T> values, string txt)
        {
            Console.WriteLine(txt);
            foreach (T value in values)
            {
                Console.WriteLine($"{value}");
            }
            Console.WriteLine("---------------------------------------------------------------\n\n");
        }
        
    }
}
