using System;
using System.Linq;
using System.Linq.Expressions;

/// <summary>
/// Base interface for common Repository function
/// T is the model and U is the data type of Id 
/// </summary>
namespace Pluto.Core.Contracts
{
    public interface IRepository<T,U>
    where T :class, IIdentifiableModel<U>
    {
        void  Add(T newEntity);
        void Remove(T entity);
        void Remove(U id);
        T Get(U id);
        IQueryable<T> Find(Expression<Func<T,bool>> predicate);
    }
}
