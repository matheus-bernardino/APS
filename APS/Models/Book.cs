using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APS.Models
{
	public class Book
	{

		public Guid BookID { get; set; }
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
        public int Quantity { get; set; }
        [Required]
        public string Images { get; set; }

		public virtual ApplicationUser ApplicationUser { get; set; }
		public virtual Purchase Purchase { get; set; }


	}
}