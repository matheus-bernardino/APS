using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APS.Models
{
	public class Book
	{

		public Guid BookId { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
        public string Author { get; set; }
        [Required]
		public string PublishingCompany { get; set; }
		[Required]
		public string Category { get; set; }
		[Required]
		public decimal Value { get; set; }
        [Required]
        public int InitialStock { get; set; }
        public int InStock { get; set; }
        public string Images { get; set; } = "";
        public bool BookStatus { get; set; } = true;

        public string SellerId { get; set; }
		public ApplicationUser ApplicationUser { get; set; }
		//public Purchase Purchase { get; set; }


	}
}