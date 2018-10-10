using APS.Data;
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

		public IEnumerable<Purchase> Purchases => _context.Purchases;

        IEnumerable<Purchase> IPurchaseRepository.Purchases { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SavePurchase(string userId, string bookId, Purchase purchase)
        {
            purchase.BuyerId = userId;
            _context.Add(purchase);
            _bookRepository.UpdateQuantity(bookId);
            _context.SaveChanges();
        }
    }
}
