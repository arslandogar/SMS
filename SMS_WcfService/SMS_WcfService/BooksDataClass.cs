using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class BooksDataClass
    {
        private static List<Book> Books = new List<Book>();

        public void addBook(Book b)
        {

        }

        public List<Book> searchByAuthor(string author)
        {
            return Books;
        }

        public List<Book> searchByName(string author)
        {
            return Books;
        }
    }
}