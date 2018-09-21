using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APS.Models;

namespace APS.Models
{
	public class Purchase
	{
		public Guid PurchaseID { get; set; }
		[ForeignKey("ApplicationUser")]
		public virtual ApplicationUser Buyer { get; set; }
		[ForeignKey("Book")]
		public virtual Book Item { get; set; }
	}
}