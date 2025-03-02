using System.Diagnostics;

namespace C__6
{
    public delegate T MyDelegate<T>(Book book);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------GetAuthors-------------------");
            LibraryEngine.ProcessBooks(Repository.Books, BookFunctions.GetAuthors);


            Console.WriteLine("-------------------GetPrice-------------------");
            LibraryEngine.ProcessBooks(Repository.Books, BookFunctions.GetPrice);


            Console.WriteLine("-------------------GetTitle-------------------");
            LibraryEngine.ProcessBooks(Repository.Books, BookFunctions.GetTitle);


            Console.WriteLine("-------------------Anonymous Method (GetISBN) -------------------");
            LibraryEngine.ProcessBooks(Repository.Books, delegate (Book B) { return B.ISBN; });


            Console.WriteLine("-------------------Lambda Expression (GetPublicationDate)-------------------");
            LibraryEngine.ProcessBooks(Repository.Books, B => B.PublicationDate);


            //Func
            Console.WriteLine("-------------------ProcessBooksFunc (Tittle&Price)-------------------");
            LibraryEngine.ProcessBooksFunc(Repository.Books, B => $"{B.Title} & {B.Price}");


            //Action
            Console.WriteLine("-------------------ProcessBooksAction (Tittle&Price&PublicationDate)-------------------");
            LibraryEngine.ProcessBooksAction(Repository.Books, B => { Console.WriteLine($"{B.Title} & {B.Price} & {B.PublicationDate}"); });
           
            
            //Predict
            Console.WriteLine("-------------------Predicate (Auther is Ali)-------------------");
            LibraryEngine.ProcessBooksPredicate(Repository.Books, B => B.Authors.Contains("Ali"));
            Console.WriteLine("-------------------Predicate (Price == 700)-------------------");
            LibraryEngine.ProcessBooksPredicate(Repository.Books, B => B.Price == 700);

        }
    }
}
