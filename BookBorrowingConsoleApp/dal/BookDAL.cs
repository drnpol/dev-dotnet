using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrowingConsoleApp.model;

namespace BookBorrowingConsoleApp.dal
{
    class BookDAL : BaseDAL<Book>
    {
        private readonly List<Book> BookList = new List<Book>()
         {
                new Book(
                    Guid.NewGuid(), "System", DateTime.Now, "System", DateTime.Now,
                    "The Great Gatsby", "F. Scott Fitzgerald"
                ),
                new Book(
                    Guid.NewGuid(), "System", DateTime.Now, "System", DateTime.Now,
                    "1984", "George Orwell"
                ),
                new Book(
                    Guid.NewGuid(), "System", DateTime.Now, "System", DateTime.Now,
                    "To Kill a Mockingbird", "Harper Lee"
                ),
                new Book(
                    Guid.NewGuid(), "System", DateTime.Now, "System", DateTime.Now,
                    "The Catcher in the Rye", "J.D. Salinger"
                ),
                new Book(
                    Guid.NewGuid(), "System", DateTime.Now, "System", DateTime.Now,
                    "Moby-Dick", "Herman Melville"
                ),
                new Book { Title = "Example Book", Author = "Adrian Rolloque"}
            };

        
        public override Book GetOne(string id)
        {
            var result = Guid.TryParse(id, out Guid guid);

            if (result)
            {
                return this.GetOne(guid);
            }
            else
            {
                throw new Exception($"Missing user with id={id}");
            }

        }
        public override Book GetOne(Guid id)
        {
            //return this.BookList.Find(user => user.Id == id);
            return this.BookList
                    .Where(book => book.Id.Equals(id))
                    .OrderBy(book => book.CreatedAt)
                    .FirstOrDefault();

        }
        public override List<Book> GetAll()
        {
            return BookList;
        }
    }
}
