using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrowingConsoleApp.dal;
using BookBorrowingConsoleApp.model;

namespace BookBorrowingConsoleApp.service
{
    class UserService
    {
        private readonly UserDAL userDAL = new UserDAL();
        public User GetUser(string userId)
        {
            return userDAL.GetOne(userId);
        }

        public User GetUserByEmail(string email)
        {
            List<User> users = this.userDAL.GetAll();

            User user = users.Find(item => item.Email == email);
            
            return user;
        }
        public List<User> GetUsers()
        {
            return userDAL.GetAll();
        }
        public Book AddBook(User user)
        {
            return null;
            // Logic to add a book
        }
        public Book UpdateBook(User user)
        {
            return null;
            // Logic to update a book
        }
        public Book DeleteBook(string userId)
        {
            return null;
            // Logic to delete a book
        }
    }
}
