using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace APS.Models
{
	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : IdentityUser
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public DateTime Birthdate { get; set; }
		public virtual ICollection<Book> Books { get; set; }
		public virtual Purchase Purchase { get; set; }

	}
}
