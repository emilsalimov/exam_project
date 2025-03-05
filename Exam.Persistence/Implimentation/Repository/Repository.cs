using Exam.Appilication.Abstraction.Repository;
using Exam.Persistence.Contex;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Exam.Persistence.Implimentation.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;
    public DbSet<T> Table => _context.Set<T>();
    public Repository(AppDbContext context)
    {
        context = _context;
    }

    public Task<IQueryable<T>> GetAllAsync()
    {
        return Task.FromResult(Table.AsQueryable());
    }
    public IQueryable<T> GetAllExpression(
           Expression<Func<T, bool>> expression = null,
           Expression<Func<T, object>> orderBy = null,
           bool ascending = true,
           bool isTracking = false,
           int skip = 0,
           int take = 10,
           params string[] includes)
    {
        IQueryable<T> query = Table;

        if (includes != null) {
            foreach (var include in includes) {
                query = query.Include(include);
            }
        }

        if (expression != null) {
            query = query.Where(expression);
        }

        if (orderBy != null) {
            query = ascending
                    ? query.OrderBy(orderBy)
                    : query.OrderByDescending(orderBy);

        }


        query = query.Skip(skip).Take(take);

        if (!isTracking) {
            query = query.AsNoTracking();
        }

        return query;


    }

   
    public async Task<T> GetByIdAsync(int id)
    {
        return await Table.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public void Update(T entity)
    {
        Table.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = Table.Find(id);
        if (entity != null)
        {
            Table.Remove(entity);
            _context.SaveChanges();
        }
    }

  
}
