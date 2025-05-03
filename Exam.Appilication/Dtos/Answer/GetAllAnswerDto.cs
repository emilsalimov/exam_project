namespace Exam.Appilication.Dtos.Answer;

public record GetAllAnswerDto(int id, string AnswerText, bool IsCorrect, int QuestionId);

