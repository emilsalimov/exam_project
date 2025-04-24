using AutoMapper;
using Exam.Appilication.Dtos.Exam;

namespace Exam.API.Profiles;

public class ExamMapper : Profile
{
    public ExamMapper()
    {
        CreateMap<Domain.Entities.Exam, GetByIdExamDto>().ReverseMap();
        CreateMap<Domain.Entities.Exam, GetAllExamDto>().ReverseMap();
    }
}