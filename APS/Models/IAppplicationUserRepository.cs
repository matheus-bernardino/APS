using System.Collections.Generic;
using System.Linq;

namespace APS.Models
{
	public interface IApplicationUserRepository
	{
		 IQueryable<ApplicationUser> ApplicationUsers { get; }
	}
}