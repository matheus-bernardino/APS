using APS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APS.Models
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private ApplicationDbContext _context;
        private IBookRepository _bookRepository;
        public PurchaseRepository(ApplicationDbContext context, IBookRepository bookRepository)
        {
            _context = context;
            _bookRepository = bookRepository;
        }

        public IEnumerable<Purchase> ListBoughtBooks(string userId)
        {
            return _context.Purchases.Where(p => p.BuyerId == userId).Include(p => p.Buyer).Include(p => p.Book);
        }

        public void SavePurchase(string userId, string bookId, Purchase purchase)
        {
            purchase.BuyerId = userId;
            purchase.BookId = new Guid(purchase.ItemId);
            _context.Add(purchase);
            _bookRepository.UpdateQuantity(bookId);
            _context.SaveChanges();
        }
    }
}
