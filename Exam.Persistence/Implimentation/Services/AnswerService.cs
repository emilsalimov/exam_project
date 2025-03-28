using Exam.Appilication.Abstraction.Repository;
using Exam.Appilication.Abstraction.Services;
using Exam.Domain.Entities;

namespace Exam.Persistence.Implimentation.Services;

public class AnswerService : IAnswerService
{
    private readonly IAnswerRepository _answerRepository;
    public AnswerService(IAnswerRepository answerRepository)
    {
        _answerRepository = answerRepository;
    }

    public async Task AddAsync(Answer entity)
    {
        await _answerRepository.AddAsync(entity);

    }

    public void Delete(int id)
    {
        _answerRepository.Delete(id);

    }

    public async Task<IQueryable<Answer>> GetAllAsync()
    {
        return await _answerRepository.GetAllAsync();
    }

    public async Task<Answer> GetByIdAsync(int id)
    {
        return await _answerRepository.GetByIdAsync(id);
    }

    public void Update(Answer entity)
    {
        _answerRepository.Update(entity);
    }

}
