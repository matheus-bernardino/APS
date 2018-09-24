using System;
using System.Collections.Generic;
using System.Linq;

namespace APS.Models
{
	public interface IApplicationUserRepository
	{
		 IEnumerable<ApplicationUser> ApplicationUsers { get; }

        bool VerifyUserStatus(string email);
        void DeactivateUser(Guid id);
        ApplicationUser GetUserById(Guid id);
	}
}