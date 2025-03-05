using Exam.Appilication.Abstraction.Repository;
using Exam.Domain.Entities;
using Exam.Persistence.Contex;

namespace Exam.Persistence.Implimentation.Repository;
public class StudentResultRepository : Repository<StudentResult>, IStudentResultRepository
{
    public StudentResultRepository(AppDbContext context) : base(context)
    {
    }
}
