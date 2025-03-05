using Exam.Appilication.Abstraction.Repository;
using Exam.Persistence.Contex;

namespace Exam.Persistence.Implimentation.Repository;
public class ExamRepository : Repository<Domain.Entities.Exam>, IExamRepository
{
    public ExamRepository(AppDbContext context) : base(context)
    {
    }
}
