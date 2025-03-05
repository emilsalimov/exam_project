using Exam.Appilication.Abstraction.Repository;
using Exam.Appilication.Abstraction.Services;

namespace Exam.Persistence.Implimentation.Services;
public class  Service<T> : IService<T> where T : class
    {
    private readonly IRepository<T> _repository;

    public Service(IRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(T entity)
    {
        await _repository.AddAsync(entity);
    }

    public void DeleteAsync(int id)
    {
         _repository.Delete(id);
    }

    public async Task<IQueryable<T>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public void  Update(T entity)
    {
         _repository.Update(entity);
    }
}
