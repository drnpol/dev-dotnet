using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Book Borrowing Console Application
 * - Must be able to secure the application via Email / Password Login
 * - Must be able manage users as an admin
 * - Mustb e able to manage books as an admin
 * - Must be able to borrow books as a user
 * - Must be able to return books as a user
 * - Must be able to calculate late fees
 */
namespace BookBorrowingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Base der = (Base) new Derived();
            Base der2 = new Derived();
            der.Print();
            der2.Print();
            Derived der3 = new Derived();
            der3.Print();
            //Application app = new Application();
            //string command = null;

            //do
            //{
            //    command = app.Process(command);
            //} while (!"exit".Equals(command));

            //Console.WriteLine("Exiting application...");
        }
    }
}
