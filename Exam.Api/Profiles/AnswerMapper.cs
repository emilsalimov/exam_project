using AutoMapper;
using Exam.Appilication.Dtos.User;
using Exam.Domain.Entities;

namespace Exam.API.Profiles;

public class AnswerMapper : Profile
{
    public AnswerMapper()
    {
        CreateMap<Answer, GetByIdUserDto>().ReverseMap();
    }
}