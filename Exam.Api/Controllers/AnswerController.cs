using AutoMapper;
using Exam.Appilication.Abstraction.Services;
using Exam.Appilication.Dtos.Answer;
using Exam.Appilication.Dtos.User;
using Exam.Domain.Entities;
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

        public IActionResult AddAnswer(AddAnswerDto request)
        {
            Answer answer = new Answer()
            {
                AnswerText = request.AnswerText,
                IsCorrect = request.IsCorrect,
                QuestionId = request.QuestionId,
            };
            _answerService.AddAsync(answer);
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
        public async Task<IActionResult> GetByIdAnswer(int id)
        {
            var result = await _answerService.GetByIdAsync(id);
            var res = _mapper.Map<GetByIdUserDto>(result);
            return Ok(res);
        }
    }
}
