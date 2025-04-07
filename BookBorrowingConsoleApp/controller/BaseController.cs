using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BookBorrowingConsoleApp.model;
using BookBorrowingConsoleApp.service;
/**
 *Due to the limitations in the console application view / ui, we had to do the view/business logic in the controller.
 */
namespace BookBorrowingConsoleApp.controller
{
    class BaseController
    {
        private readonly UserService userService = new UserService();
        
        public string Home()
        {
            Console.WriteLine("Welcome to the Book Borrowing Console Application!");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: ");


            int input = 0;
            bool success = int.TryParse(Console.ReadLine(), out input);
            if (success)
            {
                switch (input)
                {
                    case 1:
                        return "login";
                    case 2:
                        return "register";
                    case 3:
                        return "exit";
                }
            }
            return null;
        }
        public string Login()
        {
            Console.Write("Please enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();

            try
            {
                User foundUser = userService.GetUserByEmail(email);
                if (foundUser.ValidatePassword(password)){
                    return this.LoginSuccess(foundUser);
                }
                else
                {
                    return this.LoginFailed();
                }
            }
            catch (Exception ex)
            {
                return this.LoginFailed();
            }
        }
        public string LoginFailed()
        {
            Console.WriteLine("Invalid email or password. Try again!");

            return "login";
        }
        public string LoginSuccess(User user)
        {

            //@TODO - this may not be the best way to do this.
            Application.CurrentUser = user;
            
            Console.WriteLine($"Welcome back {user.Role} {user.FirstName} {user.LastName}!");

            return "app";
        }
        public string Logout()
        {
            return null;
        }
    }

    class SecureController
    {
        
        private readonly UserService userService = new UserService();
        private readonly BookService bookService = new BookService();
        
        public string App()
        {
            string backToMe = "app";
            var currentUser = Application.CurrentUser; 
            if (currentUser != null)
                
            {
                if(currentUser.Role == "ADMIN")
                {
                    Console.WriteLine("Borrowing Console Application");
                    Console.WriteLine($"[SESSION: {currentUser.Role}-{currentUser.LastName}]");
                    Console.WriteLine("1. Manage Users");
                    Console.WriteLine("2. Manage Books");
                    Console.WriteLine("3. Logout");
                    Console.Write("Please select an option: ");

                    int input = 0;
                    bool success = int.TryParse(Console.ReadLine(), out input);
                    if (success)
                    {
                        switch (input)
                        {
                            case 1:
                                return "manageUsers";
                            case 2:
                                return "manageBooks";
                            case 3:
                                return "logout";
                        }
                    }
                    return backToMe;
                }
                else
                {
                    Console.WriteLine("Borrowing Console Application");
                    Console.WriteLine($"[SESSION: {currentUser.Role}-{currentUser.LastName}]");
                    Console.WriteLine("1. Borrow Book");
                    Console.WriteLine("2. Return Book");
                    Console.WriteLine("3. Logout");
                    Console.Write("Please select an option: ");

                    int input = 0;
                    bool success = int.TryParse(Console.ReadLine(), out input);
                    if (success)
                    {
                        switch (input)
                        {
                            case 1:
                                return "manageUsers";
                            case 2:
                                return "manageBooks";
                            case 3:
                                return "logout";
                        }
                    }
                    return backToMe;
                }
            }
            return null; // back to home / public
        }

        public string ManageBooks()
        {
            string backToMe = "manageBooks";
            var currentUser = Application.CurrentUser;
            Console.WriteLine("Borrowing Console Application");
            Console.WriteLine($"[SESSION: {currentUser.Role}-{currentUser.LastName}]");
            Console.WriteLine("1. View all books");
            Console.WriteLine("2. Add Book");
            Console.WriteLine("3. Edit Book");
            Console.WriteLine("4. Delete Book");
            Console.WriteLine("5. Back");
            Console.Write("Please select an option: ");

            int input = 0;
            bool success = int.TryParse(Console.ReadLine(), out input);
            if (success)
            {
                switch (input)
                {
                    case 1:
                        return this.ViewBooks();
                    case 2:
                        return "addBook";
                    case 3:
                        return "editBook";
                    case 4:
                        return "deleteBook";
                    case 5:
                        return null;
                }
            }
            return backToMe;
        }
        public string ViewBooks()
        {
            List<Book> books = bookService.GetBooks();

            int i = 0;
            foreach(Book book in books){
                Console.WriteLine($"[{i+1}] Title: {book.Title} Author: {book.Author} Available: {true}");
                i++;
            }
            return "manageBooks";
        }
    }

    class UserController
    {
        private readonly UserService userService = new UserService();
        public List<User> GetUsers()
        {
            return userService.GetUsers();
        }
       
    }

    class BookController
    {
        private readonly BookService bookService = new BookService();
        public List<Book> GetBooks()
        {
            return bookService.GetBooks();
        }
    }
}
