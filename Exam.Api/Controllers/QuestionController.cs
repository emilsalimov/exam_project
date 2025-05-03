using AutoMapper;
using Exam.API.Profiles;
using Exam.Appilication.Abstraction.Services;
using Exam.Appilication.Dtos.Answer;
using Exam.Appilication.Dtos.Exam;
using Exam.Appilication.Dtos.Questions;
using Exam.Domain.Entities;
using Exam.Persistence.Implimentation.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exam.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        private readonly IMapper _mapper;
        public QuestionController(IQuestionService questionService, IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task< IActionResult> AddQuestions(AddQuestionDto request)
        {
            Question question = new Question()
            {
                QuestionText = request.QuestionText,
                QuestionType = request.QuestionType,
                Points = request.Points,
                ExamId = request.ExamId,
            };
             await  _questionService.AddAsync(question);
            return Ok("Question added successfully");
        }


        [HttpDelete]
        public IActionResult DeleteQuestion(RemoveQuestionDto request)
        {
            var question = _questionService.GetByIdAsync(request.id).Result;
            if (question == null)
            {

                return NotFound("Question not found");
            }
            _questionService.Delete(request.id);
            return Ok("Question deleted successfully");
        }


        [HttpPut]
        public IActionResult UpdateQuestion(UpdateQuestionDto request)
        {
            var question = _questionService.GetByIdAsync(request.id).Result;
            if (question == null)
            {
                return NotFound("Question not found");
            }

            question.QuestionText = request.QuestionText;
            question.QuestionType = request.QuestionType;
            question.Points = request.Points;
            question.ExamId = request.ExamId;
            _questionService.Update(question);
            return Ok("Question updated successfully");
        }

        [HttpGet]
        public async Task<IActionResult> GetByIdQuestion(int id)
        {
            var result = await _questionService.GetByIdAsync(id);
            var res = _mapper.Map<GetByIdQuestionDto>(result);
            return Ok(res);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllExam()
        {
            var result = await _questionService.GetAllAsync();
            var res = _mapper.Map<List<GetAllQuestionDto>>(result.ToList());
            return Ok(res);

        }
    }
}
