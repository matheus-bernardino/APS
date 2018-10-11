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
            book.InStock = book.InitialStock;
            _context.Books.Add(book);
            _context.UpdateRange();
            _context.SaveChanges();
        }

        public IEnumerable<Tuple<Book, int>> ListSoldBook(string userId)
        {
            List<Tuple<Book, int>> soldBooks = new List<Tuple<Book, int>>();
            var books = _context.Books.Where(book => book.SellerId == userId);
            foreach(var book in books)
            {
                if(book.InitialStock - book.InStock > 0)
                {
                    Tuple<Book, int> soldBook = new Tuple<Book, int>(book, book.InitialStock - book.InStock);
                    soldBooks.Append(soldBook);
                }
            }
            return soldBooks.AsEnumerable();
        }


        public void UpdateQuantity(string bookId)
        {
            Book book = (Book) _context.Books.Where(b => b.BookId == new Guid(bookId));
            book.InStock = book.InStock - 1;
            _context.SaveChanges();
            
        }

        public IEnumerable<Book> Books => _context.Books;
	}
}
