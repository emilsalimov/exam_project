using AutoMapper;
using Exam.Appilication.Dtos.User;
using Exam.Domain.Entities;

namespace Exam.API.Profiles;

public class UserMapper:Profile
{
    public UserMapper()
    {
        CreateMap<User, GetByIdUserDto>().ReverseMap();
        CreateMap<User, GetAllUserDto>().ReverseMap();
    }
}
