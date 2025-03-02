using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__6
{
    internal class LibraryEngine
    {
        public static void ProcessBooks<T>(List<Book> bList,MyDelegate<T> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooksFunc(List<Book> bList, Func<Book,string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooksAction(List<Book> bList, Action<Book> fPtr)
        {
            foreach (Book B in bList)
            {
                fPtr(B);
            }
        }
        public static void ProcessBooksPredicate(List<Book> bList, Predicate <Book> fPtr)
        {
            foreach (Book B in bList)
            {
                if (fPtr(B)) Console.WriteLine(B);
            }
        }
    } 

}
