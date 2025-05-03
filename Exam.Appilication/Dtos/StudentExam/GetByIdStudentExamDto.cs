namespace Exam.Appilication.Dtos.StudentExam;

public record GetByIdStudentExamDto(int id, DateTime StartTime, DateTime EndTime, decimal Score, int UserId, int ExamId);

