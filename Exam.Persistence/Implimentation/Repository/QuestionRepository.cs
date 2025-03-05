using Exam.Appilication.Abstraction.Repository;
using Exam.Domain.Entities;
using Exam.Persistence.Contex;

namespace Exam.Persistence.Implimentation.Repository;

public class QuestionRepository : Repository<Question>, IQuestionRepository
{
    public QuestionRepository(AppDbContext context) : base(context)
    {
    }
}
