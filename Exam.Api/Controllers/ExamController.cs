using AutoMapper;
using Exam.Appilication.Abstraction.Services;
using Exam.Appilication.Dtos.Exam;
using Exam.Appilication.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace Exam.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        private readonly IMapper _mapper;
        public ExamController(IExamService examService, IMapper mapper)
        {
            _examService = examService;
            _mapper = mapper;
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

        [HttpGet]
        public async Task<IActionResult> GetByIdExam(int id)
        {
            var result = await _examService.GetByIdAsync(id);
            var res = _mapper.Map<GetByIdExamDto>(result);
            return Ok(res);
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAllExam()
        {
            var result = await _examService.GetAllAsync();
            var res = _mapper.Map<List<GetAllExamDto>>(result.ToList());
            return Ok(res);

        }
    }
}
