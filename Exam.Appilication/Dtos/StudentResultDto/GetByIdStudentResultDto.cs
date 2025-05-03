namespace Exam.Appilication.Dtos.StudentResultDto;

public record GetByIdStudentResultDto(int id,bool IsCorrectResult, int StudentExamId, int QuestionId, int AnswerId)
