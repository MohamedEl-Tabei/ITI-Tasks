using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__8_LINQ
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
    }
}
