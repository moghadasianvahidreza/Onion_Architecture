using Models;
using Onion.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repository
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
	{
		private DatabaseContext _databaseContext;

		private DbSet<TEntity> _dbSet;

		public Repository(DatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
			_dbSet = databaseContext.Set<TEntity>();
		}

		public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter)
		{
			IQueryable<TEntity> queryable = _dbSet;

			if (filter != null)
			{
				queryable = queryable.Where(filter);
			}

			return queryable;
		}

		public TEntity GetById(System.Guid entityId)
		{
			return _dbSet.FirstOrDefault(current => current.Id == entityId);
		}

		public void Insert(TEntity tEntity)
		{
			_databaseContext.Entry(tEntity).State = EntityState.Added;
		}

		public void Update(TEntity tEntity)
		{
			_databaseContext.Entry(tEntity).State = EntityState.Modified;
		}

		public void Delete(TEntity tEntity)
		{
			_databaseContext.Entry(tEntity).State = EntityState.Deleted;
		}

		#region Dispose
		public void Dispose()
		{

		}
		#endregion
	}
}
