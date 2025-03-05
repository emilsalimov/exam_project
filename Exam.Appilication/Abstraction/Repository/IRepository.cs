using Exam.Domain.Entities;
using System.Linq.Expressions;

namespace Exam.Appilication.Abstraction.Repository;

public interface IRepository<T> where T : class
{
 
    Task<IQueryable<T>> GetAllAsync();
    IQueryable<T> GetAllExpression(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderBy, bool ascending = true, bool isTracking = true, int skip=0, int take=10,  params string[] includes);
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(int id);

}
