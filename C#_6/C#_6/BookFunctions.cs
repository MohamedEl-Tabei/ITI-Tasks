using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__6
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            string authors = "";
            foreach (var item in B.Authors) authors = $"{item},{authors}";
            return authors;
        }

        public static decimal GetPrice(Book B)
        {
            return B.Price;
        }
    }
}
