using AutoMapper;
using Exam.Appilication.Abstraction.Services;
using Exam.Appilication.Dtos.Questions;
using Exam.Appilication.Dtos.StudentExam;
using Exam.Domain.Entities;
using Exam.Persistence.Implimentation.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentExamController : ControllerBase
    {
        private readonly IStudentExamService _studentExamService;
        private readonly IMapper _mapper;

        public StudentExamController(IStudentExamService studentExamService, IMapper mapper)
        {
            _studentExamService=studentExamService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddStudentExam(AddStudentExamDto request)
        {
            StudentExam studentExam = new StudentExam()
            {
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                Score = request.Score,
                UserId = request.UserId,
                ExamId = request.ExamId,
            };
            await _studentExamService.AddAsync(studentExam);
            return Ok("StudentExam added successfully");
        }


        [HttpDelete]
        public IActionResult DeleteStudentExam(RemoveStudentExamDto request)
        {
            var studentExam = _studentExamService.GetByIdAsync(request.id).Result;
            if (studentExam == null)
            {

                return NotFound("StudentExam not found");
            }
            _studentExamService.Delete(request.id);
            return Ok("StudentExam deleted successfully");
        }

        [HttpPut]
        public IActionResult UpdateStudentExam(UpdateStudentExamDto request)
        {
            var studentExam = _studentExamService.GetByIdAsync(request.id).Result;
            if (studentExam == null)
            {
                return NotFound("StudentExam not found");
            }

            studentExam.StartTime = request.StartTime;
            studentExam.EndTime = request.EndTime;
            studentExam.Score = request.Score;
            studentExam.UserId = request.UserId;
            studentExam.ExamId = request.ExamId;
            _studentExamService.Update(studentExam);
            return Ok("StudentExam updated successfully");
        }

        [HttpGet]
        public async Task<IActionResult> GetByIdStudentExam(int id)
        {
            var result = await _studentExamService.GetByIdAsync(id);
            var res = _mapper.Map<GetByIdStudentExamDto>(result);
            return Ok(res);
        }
    }
}
