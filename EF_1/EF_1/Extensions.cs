using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_1
{
    internal static class Extensions
    {
        public static void Print<T>  (this IEnumerable<T> collection , string txt ) where T : class
        {
            Console.WriteLine("\n\n");
            Console.WriteLine($"{txt}\n");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

        }
    }
}
