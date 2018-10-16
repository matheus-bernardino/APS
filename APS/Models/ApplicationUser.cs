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
        [Required(ErrorMessage ="Insira um nome válido")]
        public string Name { get; set; }
        [Required]
        [AgeValidation(ErrorMessage ="Permitido apenas para maiores de 16 anos")]
		public DateTime Birthdate { get; set; }
        public bool Status { get; set; } = true;
        public IEnumerable<Purchase> purchases { get; set; }

		//public virtual Purchase Purchase { get; set; }

	}
}
