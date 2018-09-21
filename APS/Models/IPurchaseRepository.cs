using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APS.Models
{
	public class IPurchaseRepository
	{
		IEnumerable<Purchase> Purchases { get; set; }
	}
}
