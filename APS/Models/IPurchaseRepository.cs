using System.Collections.Generic;

namespace APS.Models
{
    public interface IPurchaseRepository
	{
		IEnumerable<Purchase> Purchases { get; set; }
        void SavePurchase(string userId, string bookId, Purchase purchase);
	}
}
