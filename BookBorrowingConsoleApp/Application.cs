using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrowingConsoleApp.controller;
using BookBorrowingConsoleApp.model;

namespace BookBorrowingConsoleApp
{
    class Application
    {
        /**
        * this is ineffective in local setup with debug though, skipping reading from JSON for now.
        */
        //string data = LocalJSONDB.LoadJSON("/resources/data/database.json");
        public static User CurrentUser { get; set; }

        string data = LocalJSONDB.LoadJSON(null);

        private BaseController baseController = new BaseController();
        private SecureController secureController = new SecureController();
        private UserController userController = new UserController();
        private BookController bookController = new BookController();
        

        public string Process(string command)
        {
            if(Application.CurrentUser != null && String.IsNullOrEmpty(command))
            {
                command = "app";
            }
            switch (command)
            {
                case null:
                    return baseController.Home();
                case "login":
                    return baseController.Login();
                case "":
                    return baseController.Home();
                case "app":
                    return secureController.App();
                case "manageUsers":
                    return secureController.ManageBooks();
                case "manageBooks":
                    return secureController.ManageBooks();
            }
            return null;
        }
    }
}
