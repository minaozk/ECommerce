using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace IconEtic.Core.DataAccess
{
    public interface IEfEntityRepositoryBase<TEntity>
    where TEntity : class, IEntity, new()
    {
        void Add (TEntity entity);

        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity,bool>> filter);
        IList<TEntity> GetAll(Expression<Func<TEntity,bool>> filter = null);
        void Update(TEntity entity);
        bool Any(Expression<Func<TEntity,bool>> filter);
    }
}
