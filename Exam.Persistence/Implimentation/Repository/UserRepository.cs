using Exam.Appilication.Abstraction.Repository;
using Exam.Domain.Entities;
using Exam.Persistence.Contex;

namespace Exam.Persistence.Implimentation.Repository;
public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}
