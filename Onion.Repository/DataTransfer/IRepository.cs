using Onion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repository
{
	public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
	{
		IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter);

		TEntity GetById(System.Guid entityId);

		void Insert(TEntity tEntity);

		void Update(TEntity tEntity);

		void Delete(TEntity tEntity);

	}
}
