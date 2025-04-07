using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingConsoleApp.model
{
    public class Book : Model
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book() : base(createdBy: null)
        {
            // empty book here... 
        }

        public Book(
            Guid id, string createdBy, DateTime createdAt, string updatedBy, DateTime updatedAt,
            string title, string author
        ) : base(id, createdBy, createdAt, updatedBy, updatedAt)
        {
            this.Title = title;
            this.Author = author;
        }
        public Book(Book book) : base(book)
        {
            this.Title = book.Title;
            this.Author = book.Author;
        }
    }
}
