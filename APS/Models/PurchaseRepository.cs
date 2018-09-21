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

		public PurchaseRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Purchase> Purchases => _context.Purchases;
	}
}
