using Exam.Appilication.Abstraction.Repository;
using Exam.Domain.Entities;
using Exam.Persistence.Contex;

namespace Exam.Persistence.Implimentation.Repository;
public class AnswerRepository : Repository<Answer>, IAnswerRepository
{
    public AnswerRepository(AppDbContext context) : base(context)
    {
    }
}
