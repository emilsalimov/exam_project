using Exam.Appilication.Abstraction.Repository;
using Exam.Appilication.Abstraction.Services;
using Exam.Domain.Entities;
using Exam.Persistence.Implimentation.Repository;


//namespace Exam.Persistence.Implimentation.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task AddAsync(User entity)
    {
        await _userRepository.AddAsync(entity);

    }

    public void Delete(int id)
    {
        _userRepository.Delete(id);

    }

    public async Task<IQueryable<User>> GetAllAsync()
    {
        return await _userRepository.GetAllAsync();
    }

    public async Task<User> GetByIdAsync(int id)
    {
        return await _userRepository.GetByIdAsync(id);
    }

    public void Update(User entity)
    {
        _userRepository.Update(entity);
    }
}
