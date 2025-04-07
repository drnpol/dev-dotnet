using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingConsoleApp.model
{
    public class User : Model
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age{ get; set; }
        public string Email { get; set; }  
        public string Password { get; set; }
        public string Role { get; set; }

       public User(): base(createdBy: null)
       {
        // empty user here... 
       }

        public User(
            Guid id, string createdBy, DateTime createdAt, string updatedBy, DateTime updatedAt,
            string firstName, string lastName, int age, string email, string password, string role
        ) : base(id, createdBy, createdAt, updatedBy, updatedAt)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.Role = role;
        }
        public User(User user) : base(user)
        {
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Age = user.Age;
            this.Email = user.Email;
            this.Password = user.Password;
            this.Role = user.Role;
        }

        public bool ValidatePassword(string password)
        {
            return this.Password.Equals(password);
        }
    }
}
