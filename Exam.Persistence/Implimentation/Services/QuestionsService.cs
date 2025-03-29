using Exam.Appilication.Abstraction.Services;
using Exam.Domain.Entities;

namespace Exam.Persistence.Implimentation.Services;

public class QuestionsService : IQuestionsService
{
    private readonly IQuestionsService _questionsService;
    public QuestionsService(IQuestionsService questionsService)
    {
        _questionsService = questionsService;
    }
    public async Task AddAsync(Question entity)
    {
        await _questionsService.AddAsync(entity);

    }

    public void Delete(int id)
    {
        _questionsService.Delete(id);
    }

    public async Task<IQueryable<Question>> GetAllAsync()
    {
        return await _questionsService.GetAllAsync();
    }

    public async Task<Question> GetByIdAsync(int id)
    {
        return await _questionsService.GetByIdAsync(id);
    }

    public void Update(Question entity)
    {
        _questionsService.Update(entity);
    }

}
