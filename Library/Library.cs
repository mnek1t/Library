using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     sealed class Library
    {
        private List<Book> library = new List<Book>();
        
        public void AddBook(Book book)
        {
            if (library.Contains(book))
            {
                Console.WriteLine("Book is already added!");
            }
            else 
            {
                library.Add(book);
            }
        }

        public void PrintLibrary()
        {
           
            foreach (Book book in library)
            {
                Console.WriteLine($"'{book.GetAuthor()}'  '{book.GetTitle()}'  '{book.GetContent()}'");
            }
   
        }

        public void RemoveBook(Book book)
        {
            if (library.Contains(book))
            {
                library.Remove(book);
            }
            else
            {
                Console.WriteLine("Book does not exist int the library!");
            }
        }

        public Book GetBookFromLibrary(Book book)
        {
            if (library.Contains(book))
            {
                return book;
            }
            else 
            {
                return null; 
            }
        }

        public bool isEmpty()
        {
            if (library.Count != 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Library is Empty!");
                return true;
            }
        }
    }
}
