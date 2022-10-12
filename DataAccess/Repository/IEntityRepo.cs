using System.Linq.Expressions;

namespace RpiServerAPI.DataAccess.Repository;

public interface IEntityRepo<T> where T:class,new()
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    List<T> GetAll(Expression<Func<T,bool>> filter=null);
    T GetById(Expression<Func<T, bool>> filter);
    T Get(Expression<Func<T, bool>> filter);

}