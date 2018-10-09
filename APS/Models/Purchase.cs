using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APS.Models;

namespace APS.Models
{
	public class Purchase
	{
		public Guid PurchaseId { get; set; }
        public string BuyerId { get; set; }
		public ApplicationUser ApplicationUser { get; set; }
        public string ItemId { get; set; }
		public Book Book { get; set; }
	}
}