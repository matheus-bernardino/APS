using System.Collections.Generic;
using APS.Data;
using System.Linq;

namespace APS.Models
{
	public class ApplicationUserRepository : IApplicationUserRepository
	{
		private ApplicationDbContext _context;
		public ApplicationUserRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public IQueryable<ApplicationUser> ApplicationUsers => throw new System.NotImplementedException();
	}
}