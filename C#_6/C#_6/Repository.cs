using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__6
{
    internal class Repository
    {
        public static List<Book> Books { get; set; }
        static Repository()
        {
            Books = new List<Book>()
            {
                new Book("1", "Title1", ["Ahmed", "Ali"], DateTime.Now.AddDays(1),10*22),
                new Book("2", "Title2", ["Ahmed"], DateTime.Now.AddDays(1),10*55),
                new Book("3", "Title3",["Ali"], DateTime.Now.AddDays(1),100*7),
                new Book("4", "Title4",["Mohamed", "Aya"], DateTime.Now.AddDays(1),10*8),
                new Book("5", "Title5",["Omar", "Aya"], DateTime.Now.AddDays(1),100*3),
                new Book("6", "Title6",["Ziad", "Ali"], DateTime.Now.AddDays(1),100*7)
            };
        }
    }
}
