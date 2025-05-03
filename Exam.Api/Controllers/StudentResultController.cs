using AutoMapper;
using Exam.Appilication.Abstraction.Services;
using Exam.Appilication.Dtos.Questions;
using Exam.Appilication.Dtos.StudentResultDto;
using Exam.Domain.Entities;
using Exam.Persistence.Implimentation.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentResultController : ControllerBase
    {
        private readonly IStudentResultService _studentResultService;
        private readonly IMapper _mapper;
        public StudentResultController(IStudentResultService studentResultService, IMapper mapper)
        {
            _studentResultService = studentResultService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestions(AddStudentResultDto request)
        {
            StudentResult studentResult = new StudentResult()
            {
                IsCorrectResult = request.IsCorrectResult,
                StudentExamId = request.StudentExamId,
                QuestionId = request.QuestionId,
                AnswerId = request.AnswerId,
            };
            await _studentResultService.AddAsync(studentResult);
            return Ok("StudentResult added successfully");
        }
        [HttpDelete]
        public IActionResult DeleteStudentResult(RemoveStudentResultDto request)
        {
            var studentResult = _studentResultService.GetByIdAsync(request.id).Result;
            if (studentResult == null)
            {

                return NotFound("StudentResult not found");
            }
            _studentResultService.Delete(request.id);
            return Ok("StudentResult deleted successfully");
        }


        [HttpPut]
        public IActionResult UpdateStudentResult(UpdateStudentResultDto request)
        {
            var studentResult = _studentResultService.GetByIdAsync(request.id).Result;
            if (studentResult == null)
            {
                return NotFound("StudentResult not found");
            }

            studentResult.IsCorrectResult = request.IsCorrectResult;
            studentResult.StudentExamId = request.StudentExamId;
            studentResult.QuestionId = request.QuestionId;
            studentResult.AnswerId = request.AnswerId;
            _studentResultService.Update(studentResult);
            return Ok("StudentResult updated successfully");
        }
        [HttpGet]
        public async Task<IActionResult> GetByIdStudentResult(int id)
        {
            var result = await _studentResultService.GetByIdAsync(id);
            var res = _mapper.Map<GetByIdStudentResultDto>(result);
            return Ok(res);
        }
    }
}
