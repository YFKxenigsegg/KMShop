using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace KMShop.Data.Interfaces
{
    public interface IRepository<T>
    {
        int Add(T entity);
        int Add(IList<T> entities);
        int Update(T entity);
        int Update(IList<T> entities);
        int Deleted(T entity);
        T GetOne(int? id);
        List<T> GetSome(Expression<Func<T, bool>> where);
        List<T> GetAll();
        List<T> GetAll<TSortField>(Expression<Func<T, TSortField>> orderBy,
        bool ascending);
    }
}
