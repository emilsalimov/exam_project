using AutoMapper;
using Exam.Appilication.Dtos.Questions;
using Exam.Appilication.Dtos.StudentExam;
using Exam.Domain.Entities;

namespace Exam.API.Profiles;

public class StudentExamMapper : Profile
{
    public StudentExamMapper()
    {
        CreateMap<StudentExam, GetByIdStudentExamDto>().ReverseMap();
    }
}