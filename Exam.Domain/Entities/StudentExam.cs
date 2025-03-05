namespace Exam.Domain.Entities;
public class StudentExam : BaseEntity
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public decimal Score { get; set; }
    public int UserId { get; set; }
    public int ExamId { get; set; }
    public StudentResult StudentResut { get; set; }
    public Exam Exam { get; set; }
    public User User { get; set; }

}
