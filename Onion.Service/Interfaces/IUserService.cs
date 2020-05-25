using Onion.Data;
using Onion.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service
{
	public interface IUserService : IDisposable
	{
		User GetUserByUserId(Guid userId);

		void CreateUser(User user);

		void UpdateUser(User user);

		void DeleteUser(User user);

		void DeleteUser(Guid userId);


	}
}
