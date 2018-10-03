using System.Collections.Generic;
using System.Linq;

namespace APS.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }

        void RegisterBook(Book book);
    }
}