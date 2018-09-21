using System.Collections.Generic;
using System.Linq;

namespace APS.Models
{
	public interface IBookRepository
	{
		IQueryable<Book> Books { get; }
	}
}