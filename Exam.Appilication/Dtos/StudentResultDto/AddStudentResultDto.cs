namespace Exam.Appilication.Dtos.StudentResultDto;
public record AddStudentResultDto(  bool IsCorrectResult, int StudentExamId, int QuestionId, int AnswerId);