using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class BooksDataClass
    {
        private static List<Book> books = new List<Book>();

        public static List<Book> Books
        {
            get
            {
                return books;
            }

            set
            {
                books = value;
            }
        }

        public static void addBook(Book b)
        {
            books.Add(b);

        }


        public static List<Book> searchByAuthor(string author)
        {
            List<Book> temp = new List<Book>();
            foreach(Book b in books)
            {
                if(b.Author == author)
                {
                    temp.Add(b);
                }
            }
            return temp;
        }

        public static List<Book> searchByName(string name)
        {
            List<Book> temp = new List<Book>();
            foreach (Book b in books)
            {
                if (b.Title == name)
                {
                    temp.Add(b);
                }
            }
            return temp;
        }
    }
}