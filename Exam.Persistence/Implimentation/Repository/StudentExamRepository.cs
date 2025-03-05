using Exam.Appilication.Abstraction.Repository;
using Exam.Domain.Entities;
using Exam.Persistence.Contex;

namespace Exam.Persistence.Implimentation.Repository;
public class StudentExamRepository : Repository<StudentExam>, IStudentExamRepository
{
    public StudentExamRepository(AppDbContext context) : base(context)
    {
    }
}
