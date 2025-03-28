namespace Exam.Appilication.Dtos.Answer;

public record UpdateAnswerDto(int id,  string AnswerText,bool IsCorrect,  int QuestionId );

