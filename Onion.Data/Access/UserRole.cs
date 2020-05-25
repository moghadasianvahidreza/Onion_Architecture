using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onion.Data
{
public	class UserRole : BaseEntity
	{
		public UserRole() : base()
		{

		}

		public int UserId { get; set; }

		public int RoleId { get; set; }

		public virtual Role Role { get; set; }

		public virtual User User { get; set; }
	}
}
