using Exam.Appilication.Abstraction.Repository;
using Exam.Appilication.Abstraction.Services;

namespace Exam.Persistence.Implimentation.Services;

public class ExamService : IExamService
{
    private readonly IExamRepository _examRepository;

    public ExamService(IExamRepository examRepository)
    {
        _examRepository = examRepository;
    }
    public async Task AddAsync(Domain.Entities.Exam entity)
    {
        await _examRepository.AddAsync(entity);

    }

    public void Delete(int id)
    {
        _examRepository.Delete(id);
    }

    public async Task<IQueryable<Domain.Entities.Exam>> GetAllAsync()
    {
        return await _examRepository.GetAllAsync();
    }

    public async Task<Domain.Entities.Exam> GetByIdAsync(int id)
    {
        return await _examRepository.GetByIdAsync(id);
    }

    public void Update(Domain.Entities.Exam entity)
    {
        _examRepository.Update(entity);
    }
}
