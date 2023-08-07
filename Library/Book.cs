using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
