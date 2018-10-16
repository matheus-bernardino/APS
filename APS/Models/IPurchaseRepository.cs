using System.Collections.Generic;

namespace APS.Models
{
    public interface IPurchaseRepository
	{
        void SavePurchase(string userId, string bookId, Purchase purchase);
        IEnumerable<Purchase> ListBoughtBooks(string userId);
	}
}
