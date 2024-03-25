using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaratonApp.DAL.Repositories.Abstract
{
    public interface IRepository<T>
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public void Remove(T entity);
        public IQueryable<T> GetAll();
        public T GetById(int id);
        public IQueryable<T> Search(Expression<Func<T, bool>> predicate);
        public IQueryable<T> GetAllWithIncludes();
        public IQueryable<T> GetAllWithIncludes(params string[] navigationProperties);
    }
}
