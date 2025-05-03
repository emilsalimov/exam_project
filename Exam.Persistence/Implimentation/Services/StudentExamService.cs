using Exam.Appilication.Abstraction.Repository;
using Exam.Appilication.Abstraction.Services;
using Exam.Domain.Entities;

namespace Exam.Persistence.Implimentation.Services;

public class StudentExamService : IStudentExamService
{
    private readonly IStudentExamRepository _studentExamRepository;

    public StudentExamService(IStudentExamRepository studentExamRepository)
    {
        _studentExamRepository = studentExamRepository;
    }
    public async Task AddAsync(StudentExam entity)
    {
       await _studentExamRepository.AddAsync(entity);
    }

    public void Delete(int id)
    {
        _studentExamRepository.Delete(id);
    }

    public async Task<IQueryable<StudentExam>> GetAllAsync()
    {
       return await _studentExamRepository.GetAllAsync();
    }

    public async Task<StudentExam> GetByIdAsync(int id)
    {
        return await _studentExamRepository.GetByIdAsync(id);
    }

    public void Update(StudentExam entity)
    {
        _studentExamRepository.Update(entity);
    }
}
