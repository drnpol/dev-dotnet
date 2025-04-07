using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrowingConsoleApp.model;

namespace BookBorrowingConsoleApp.dal
{   
    
    class UserDAL
    {
        private readonly List<User> UserList = new List<User>()
        {
                new User(
                    Guid.NewGuid(), "System", DateTime.Now, "System", DateTime.Now,
                    "John", "Doe", 30, "jdoe@test.com", "123","ADMIN"
                ),
                new User(
                    Guid.NewGuid(), "System", DateTime.Now, "System", DateTime.Now,
                    "Jane", "Doe", 28, "jndoe@test.com", "123", "USER"
                )
            };

        public User GetOne(string id)
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
        public User GetOne(Guid id)
        {
            return this.UserList.Find(user => user.Id == id);
        }
        public List<User> GetAll()
        {
            return UserList;
        }
    }
}
