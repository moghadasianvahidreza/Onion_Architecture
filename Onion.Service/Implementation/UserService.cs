using Onion.Data;
using Onion.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service.Implementation
{
	public class UserService : IUserService
	{
		IRepository<User> _userRepository;

		public UserService(IRepository<User> _userRepository)
		{
			this._userRepository = _userRepository;
		}

		public User GetUserByUserId(Guid userId)
		{
			return _userRepository.GetById(userId);
		}


		public void CreateUser(User user)
		{
			_userRepository.Insert(user);
		}

		public void UpdateUser(User user)
		{
			_userRepository.Update(user);
		}

		public void DeleteUser(User user)
		{
			_userRepository.Update(user);
		}

		public void DeleteUser(Guid userId)
		{
			var user = GetUserByUserId(userId);

			user.IsDeleted = true;

			DeleteUser(user);
		}



		#region Dispose
		public void Dispose()
		{
			_userRepository?.Dispose();
		}
		#endregion
	}
}
