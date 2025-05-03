namespace Exam.Appilication.Dtos.StudentExam;

public record AddStudentExamDto( DateTime StartTime, DateTime EndTime, decimal Score,int UserId, int ExamId);
