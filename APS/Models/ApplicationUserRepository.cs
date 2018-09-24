using System.Collections.Generic;
using APS.Data;
using System.Linq;
using System;

namespace APS.Models
{
	public class ApplicationUserRepository : IApplicationUserRepository
	{
		private ApplicationDbContext _context;
		public ApplicationUserRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public IEnumerable<ApplicationUser> ApplicationUsers => throw new System.NotImplementedException();

        public void DeactivateUser(Guid id)
        {
            var user = _context.Users.Find(id.ToString());
            user.Status = false;
            _context.Update(user);
            _context.SaveChanges();
        }

        public ApplicationUser GetUserById(Guid id)
        {
            return _context.Users.Find(id);
        }

        public bool VerifyUserStatus(string email)
        {
            var user = _context.Users.Where(p => p.Email == email);

            if (user.Count() > 0)
            {
                return user.First().Status;
            }
            return true;
        }

    }
}