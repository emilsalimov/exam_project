using Exam.Appilication.Abstraction.Repository;
using Exam.Appilication.Abstraction.Services;
using Exam.Domain.Entities;

namespace Exam.Persistence.Implimentation.Services;
public class StudentResultService : IStudentResultService
{

    private readonly IStudentResultRepository _studentResultRepository;

    public StudentResultService(IStudentResultRepository studentResultRepository)
    {
        _studentResultRepository = studentResultRepository;
    }
    public async Task AddAsync(StudentResult entity)
    {
        await _studentResultRepository.AddAsync(entity);
    }

    public void Delete(int id)
    {
        _studentResultRepository.Delete(id);
    }

    public async Task<IQueryable<StudentResult>> GetAllAsync()
    {
        return await _studentResultRepository.GetAllAsync();
    }

    public async Task<StudentResult> GetByIdAsync(int id)
    {
        return await _studentResultRepository.GetByIdAsync(id);
    }

    public void Update(StudentResult entity)
    {
        _studentResultRepository.Update(entity);
    }
}
