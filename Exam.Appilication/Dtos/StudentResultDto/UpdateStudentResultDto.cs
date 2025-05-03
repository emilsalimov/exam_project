namespace Exam.Appilication.Dtos.StudentResultDto;

public record UpdateStudentResultDto(int id, bool IsCorrectResult, int StudentExamId, int QuestionId, int AnswerId);
