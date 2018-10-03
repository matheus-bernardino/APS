using APS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APS.Models
{
	public class BookRepository : IBookRepository
	{
		private ApplicationDbContext _context;

		public BookRepository(ApplicationDbContext context)
		{
			_context = context;
		}

        public void RegisterBook(Book book)
        {
            _context.Books.Add(book);
            _context.UpdateRange();
            _context.SaveChanges();
        }

		public IEnumerable<Book> Books => _context.Books;
	}
}
