using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BookBorrowingConsoleApp.dal;
using BookBorrowingConsoleApp.model;

namespace BookBorrowingConsoleApp.service
{
    class BookService
    {
        private readonly BookDAL bookDAL = new BookDAL();
        public Book GetBook(string bookId)
        {
            return bookDAL.GetOne(bookId);
        }
        public List<Book> GetBooks()
        {
            return bookDAL.GetAll();
        }
        public Book AddBook(Book book)
        {
            return null;
            // Logic to add a book
        }
        public Book UpdateBook(Book book)
        {
            return null;
            // Logic to update a book
        }
        public Book DeleteBook(string bookId)
        {
            return null;
            // Logic to delete a book
        }
    }
}
