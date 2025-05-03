using AutoMapper;
using Exam.Appilication.Abstraction.Services;
using Exam.Appilication.Dtos.Answer;
using Exam.Appilication.Dtos.Exam;
using Exam.Appilication.Dtos.User;
using Exam.Domain.Entities;
using Exam.Persistence.Implimentation.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exam.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;
        private readonly IMapper _mapper;
        public AnswerController(IAnswerService answerService, IMapper mapper)
        {
            _answerService = answerService;
            _mapper = mapper;
        }     
        [HttpPost]

        public async Task<IActionResult> AddAnswer(AddAnswerDto request)
        {
            Answer answer = new Answer()
            {
                AnswerText = request.AnswerText,
                IsCorrect = request.IsCorrect,
                QuestionId = request.QuestionId,
            };
        await    _answerService.AddAsync(answer);
            return Ok("Answer added successfully");
        }
        [HttpDelete]
        public IActionResult RemoveAnswer(RemoveAnswerDto request)
        {
            var answer = _answerService.GetByIdAsync(request.id).Result;
            if (answer == null)
            {

                return NotFound("Anser not found");
            }
            _answerService.Delete(request.id);
            return Ok("Answer deleted successfully");
        }
        [HttpPut]
        public IActionResult UpdateAnswer(UpdateAnswerDto request)
        {
            var answer = _answerService.GetByIdAsync(request.id).Result;
            if (answer == null)
            {
                return NotFound("Answer not found");
            }
            answer.AnswerText = request.AnswerText;
            answer.IsCorrect = request.IsCorrect;
            answer.QuestionId = request.QuestionId;

            _answerService.Update(answer);
            return Ok("Answer updated successfully");
        }
        [HttpGet]
        public async Task<IActionResult> GetByIdUser(int id)
        {
            var result = await _answerService.GetByIdAsync(id);
            var res = _mapper.Map<GetByIdAnswerDto>(result);
            return Ok(res);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllExam()
        {
            var result = await _answerService.GetAllAsync();
            var res = _mapper.Map<List<GetAllAnswerDto>>(result.ToList());
            return Ok(res);

        }
    }
}
