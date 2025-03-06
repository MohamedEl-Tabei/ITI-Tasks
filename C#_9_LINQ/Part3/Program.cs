using System.Net.NetworkInformation;
using static Part3.SampleData;
namespace Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1 - Display book title and its ISBN.
            Books.Select(b => new { Title = b.Title, ISBN = b.Isbn }).Print("1 - Display book title and its ISBN.");
            #endregion


            #region 2 - Display the first 3 books with price more than 25.
            Books.Where(b => b.Price > 25).Take(3).Print("2 - Display the first 3 books with price more than 25.");
            #endregion


            #region 3 - Display Book title along with its publisher name.
            Books.Select(b => new{ PublisherName = b.Publisher.Name,Title=b.Title})
                .Print("3 - Display Book title along with its publisher name.");
            #endregion


            #region  4 - Find the number of books which cost more than 20.
            Console.WriteLine("4 - Find the number of books which cost more than 20.");
            Console.WriteLine($"Count-> {Books.Count(b => b.Price > 20)}");
            Console.WriteLine("------------------------------------------------\n\n");
            #endregion


            #region  5 - Display book title, price and subject name sorted by its subject name ascending and by its price descending.
            Books.Select(b => new { title = b.Title, price = b.Price, subjectName = b.Subject.Name })
                .OrderBy(b => b.subjectName)
                .ThenByDescending(b=>b.price)
                .Print("5 - Display book title, price and subject name sorted by its subject name ascending and by its price descending.");

            #endregion


            #region 6 - Display all subjects with books related to this subject. (Using 2 methods).
            var q6= Books.Select(b => new { b, SubjectName = b.Subject.Name }).GroupBy(b => b.SubjectName);
            Console.WriteLine("6 - Display all subjects with books related to this subject. (Using 2 methods).");
            foreach (var book in q6)
            {
                Console.WriteLine(book.Key);
                foreach (var item in book)
                {
                    Console.WriteLine($"\t{item.b}");
                }
            }
            Console.WriteLine("------------------------------------------------\n\n");
            var q7 = (
                from book in Books
                group book.Title by book.Subject.Name
                );
            foreach (var book in q7)
            {
                Console.WriteLine(book.Key);
                foreach (var item in book)
                {
                    Console.WriteLine($"\t{item}");
                }
            }
            Console.WriteLine("------------------------------------------------\n\n");

            #endregion


            #region 7 - Display books grouped by publisher &Subject.
            Console.WriteLine("7 - Display books grouped by publisher &Subject.");
            var q8 = Books.GroupBy(b => new { publisher = b.Publisher.Name, subject = b.Subject.Name });
            
            foreach (var book in q8)
            {
                Console.WriteLine(book.Key);
                foreach (var item in book)
                {
                    Console.WriteLine($"\t{item}");
                }
            }
            #endregion

        }
    }
}
