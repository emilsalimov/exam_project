namespace Exam.Appilication.Dtos.Questions;

public record GetAllQuestionDto(int id, string QuestionText, string QuestionType, decimal Points, int ExamId);


