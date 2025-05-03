using AutoMapper;
using Exam.Appilication.Dtos.Answer;
using Exam.Appilication.Dtos.Exam;
using Exam.Appilication.Dtos.Questions;
using Exam.Domain.Entities;

namespace Exam.API.Profiles;

public class QuestionMapper : Profile
{
    public QuestionMapper()
    {
        CreateMap<Question, GetByIdQuestionDto>().ReverseMap();
        CreateMap<Question, GetAllQuestionDto>().ReverseMap();
    }
}