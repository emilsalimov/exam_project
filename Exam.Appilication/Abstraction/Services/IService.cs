namespace Exam.Appilication.Abstraction.Services;

public interface IService<T> where T : class
{
    Task AddAsync(T entity);
    void DeleteAsync(int id);
    Task<IQueryable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    void Update(T entity);

}
