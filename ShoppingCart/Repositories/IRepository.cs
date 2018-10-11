using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShoppingCart.Repositories
{
    public interface IRepository<TEntity> : IDisposable
            where TEntity : class 
    {
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(int id);

        TEntity FindById(int id);
        TEntity FindByStrId(string id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        IEnumerable<TEntity> GetAll();
    }
}
