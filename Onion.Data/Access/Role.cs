using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onion.Data
{
	public class Role : BaseEntity
	{
		public Role() : base()
		{

		}

		public virtual ICollection<UserRole> UserRoles { get; set; }

		[Display(Name = "عنوان")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		[StringLength(maximumLength: 100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
		public string Title { get; set; }

		[Display(Name = "نام سیستمی")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		[StringLength(maximumLength: 100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
		public string Name { get; set; }

		public bool IsDeleted { get; set; }
	}
}
