using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrowingConsoleApp.model;

namespace BookBorrowingConsoleApp.dal
{
	interface IBaseDAL<T> where T : Model
	{
		public T GetOne(string id);
		public T GetOne(Guid id);
		public List<T> GetAll();
	}
}
