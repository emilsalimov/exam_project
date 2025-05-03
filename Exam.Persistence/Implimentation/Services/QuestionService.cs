using Exam.Appilication.Abstraction.Repository;
using Exam.Appilication.Abstraction.Services;
using Exam.Domain.Entities;

namespace Exam.Persistence.Implimentation.Services;

public class QuestionService : IQuestionService
{
    private readonly IQuestionRepository _questionRepository;
    public QuestionService(IQuestionRepository questionRepository)
    {
        _questionRepository = questionRepository;
    }
    public async Task AddAsync(Question entity)
    {
        await _questionRepository.AddAsync(entity);

    }

    public void Delete(int id)
    {
        _questionRepository.Delete(id);
    }

    public async Task<IQueryable<Question>> GetAllAsync()
    {
        return await _questionRepository.GetAllAsync();
    }

    public async Task<Question> GetByIdAsync(int id)
    {
        return await _questionRepository.GetByIdAsync(id);
    }

    public void Update(Question entity)
    {
        _questionRepository.Update(entity);
    }
}
