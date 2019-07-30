using BookManagementSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Data
{
    public static class BookDb
    {
        private static ArrayList _db;

        static BookDb()
        {
            _db = new ArrayList();
        }

        public static void Add(Book book)
        {
            if(book != null)
            {
                _db.Add(book);
            }
        }
        public static ArrayList GetAllBooks()
        {
            return _db;
        }
        public static Book GetBookById(int id)
        {
            Book bk = null;
            foreach (Book book in _db)
            {
                if(book.Id == id)
                {
                    bk = book;
                    break;
                }
            }
            return bk;
        }
        public static bool HasBook(Book book)
        {
            bool found = false;
            foreach (Book bk in _db)
            {
                if (bk == book)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }
    }
}
