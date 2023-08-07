using System;
using Library_Myextentions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("1939","John Orwell", "Content");
            Book book2 = new Book("The Old Man and the Sea", "Ernest Hemingway", "He was an old man who fished alone");

            library.AddBook(book1);
            library.AddBook(book2);

            if (!library.isEmpty())
            {
                library.PrintLibrary();
                if (library.GetBookFromLibrary(book2) != null)
                {
                    book2.FindNext("man");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Such book does not exist in library");
                }
            }
        }
    }
}
