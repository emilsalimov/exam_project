using AutoMapper;
using Exam.Appilication.Dtos.StudentExam;
using Exam.Appilication.Dtos.StudentResultDto;
using Exam.Domain.Entities;

namespace Exam.API.Profiles
{
    public class StudentResultMapper : Profile
    {
        public StudentResultMapper()
        {
            CreateMap<StudentResult, GetByIdStudentResultDto>().ReverseMap();
        }
    }
}