namespace Exam.Appilication.Dtos;

public class StudentExamDto
{
    public int StudentExamId { get; set; }
    public int UserId { get; set; }
    public int ExamId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public decimal Score { get; set; }
}
