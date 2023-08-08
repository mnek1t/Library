using Library_Myextentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private Title title = new Title();
        private Author author = new Author();
        private Content content = new Content();
        public Book(string _title, string _author, string _content)
        {
            title.MyTitle = _title;
            author.MyAuthor = _author;
            content.MyContent = _content;
        }
        public class Notes 
        {
            private string notes;
            public void RecordNotes(Book book,string notes)
            {
                
                int index = FindAndReplaceManager.KMPSearch(book, notes);
                if (index != -1)
                {
                    this.notes += notes + " ";
                    Console.WriteLine("Notes added.");
                }
                else
                {
                    Console.WriteLine($"\nText is not found in the content of '{book.GetTitle()}' book!\nImpossible to record notes!");
                }
            }
            public void PrintNotes()
            {
                Console.WriteLine(notes);
            }
            public void ClearNotes()
            {
                notes = null;
            }
        }
        public string GetTitle()
        {
            return title.MyTitle;
        }
        public string GetAuthor()
        {
            return author.MyAuthor;
        }
        public string GetContent()
        {
            return content.MyContent;
        }

    }
}
