namespace Exam.Appilication.Dtos.Questions;

public record GetByIdQuestionDto(int id, string QuestionText, string QuestionType, decimal Points, int ExamId);

