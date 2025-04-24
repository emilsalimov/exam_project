namespace Exam.Appilication.Dtos.Answer;

public record GetByIdAnswerDto(int id, string AnswerText, bool IsCorrect, int QuestionId);
