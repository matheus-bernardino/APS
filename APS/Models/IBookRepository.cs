using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APS.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }
        void RegisterBook(Book book);
        IEnumerable<Tuple<Book, int>> ListSoldBook(string userId);
        void UpdateQuantity(string bookId);
        void UpdateBook(Book book);
        string SaveImage(IFormFile image);
    }
}