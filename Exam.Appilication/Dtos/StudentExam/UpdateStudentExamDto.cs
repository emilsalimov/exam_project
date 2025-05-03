namespace Exam.Appilication.Dtos.StudentExam;

public record UpdateStudentExamDto( int id, DateTime StartTime, DateTime EndTime, decimal Score, int UserId, int ExamId);
