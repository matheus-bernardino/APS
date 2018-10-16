using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APS.Models;

namespace APS.Models
{
	public class Purchase
	{
		public Guid PurchaseId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public bool CardType { get; set; } = true;
        public string BuyerId { get; set; }
		public ApplicationUser Buyer { get; set; }
        public string ItemId { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
	}
}