using ShoppingCart.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Utilities;

namespace ShoppingCart.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext ApplicationDbContext { get; set; }

        public RepositoryBase(ApplicationDbContext pRepositoryContext)
        {
            this.ApplicationDbContext = pRepositoryContext;
            ApplicationDbContext.ThrowIfArgumentNull(nameof(ApplicationDbContext));
        }
        public IEnumerable<T> FindAll()
        {
            return this.ApplicationDbContext.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.ApplicationDbContext.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            this.ApplicationDbContext.Set<T>().Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            this.ApplicationDbContext.Set<T>().Update(entity);
            Save();
        }

        public void Delete(T entity)
        {
            this.ApplicationDbContext.Set<T>().Remove(entity);
            Save();
        }

        public void Save()
        {
            this.ApplicationDbContext.SaveChanges();
        }
    }
}
