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
        delegate void PrintToConsole();
        static void Main(string[] args)
        {
            Library library = Library.CreateLibrary();

            Book book1 = new Book("1939","John Orwell", "Content");
            Book book2 = new Book("The Old Man and the Sea", "Ernest Hemingway", "He was an old man who fished alone");
            Book.Notes nt = new Book.Notes();

            PrintToConsole printer = () => library.PrintLibrary();

            //Adding books to the library
            library.AddBook(book1);
            library.AddBook(book2);

            if (!library.isEmpty())
            {
                //library.PrintLibrary();
                printer.Invoke();
                printer = () => nt.PrintNotes();

                //testing nested classes, adding NOTES functionality
                nt.RecordNotes(book2, "dadad");
                //nt.PrintNotes(); 
                printer.Invoke();
                nt.ClearNotes();
                // Find string in the content of the book is such exists
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
