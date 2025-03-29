using Exam.Appilication.Abstraction.Services;
using Exam.Appilication.Dtos.Exam;
using Exam.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exam.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        public ExamController(IExamService examService)
        {
            _examService = examService;
        }
        [HttpPost]

        public IActionResult AddExam(AddExamDto request)
        {

            Domain.Entities.Exam exam = new Domain.Entities.Exam()
            {
                Name = request.Name,
                Description = request.Description,
                Date = request.Date,
                Duration = request.Duration,

            };
            _examService.AddAsync(exam);
            return Ok("Exam added successfully");
        }

        [HttpDelete]
        public IActionResult DeleteExam(RemoveExamDto request)
        {

            var exam = _examService.GetByIdAsync(request.id).Result;
            if (exam == null)
            {

                return NotFound("Exam not found");
            }
            _examService.Delete(request.id);
            return Ok("Exam deleted successfully");

        }

        [HttpPut]

        public IActionResult UpdateExam(UpdateExamDto request)
        {
            var exam = _examService.GetByIdAsync(request.id).Result;
            if (exam == null)
            {
                return NotFound("Exam not found");
            }
            exam.Name = request.Name;
            exam.Description = request.Description;
            exam.Date = request.Date;
            exam.Duration = request.Duration;

            _examService.Update(exam);
            return Ok("exam updated successfully");

        }


    }
}
