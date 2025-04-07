using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrowingConsoleApp.model;

namespace BookBorrowingConsoleApp.dal
{
    /**
     * Making this abstracted for now due to current implementation of the lists
     */
    abstract class BaseDAL<T> where T: Model
    {
        public abstract T GetOne(string id);
        public abstract T GetOne(Guid id);
        public abstract List<T> GetAll();
    }
}
