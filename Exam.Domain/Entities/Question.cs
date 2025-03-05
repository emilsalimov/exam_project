namespace Exam.Domain.Entities;
public class Question: BaseEntity
{
    public string QuestionText { get; set; }
    public string QuestionType { get; set; }
    public decimal Points { get; set; }
    public int ExamId { get; set; }
    public StudentResult StudentResut { get; set; }
    public Exam Exam { get; set; }
    public List<Answer> Answers { get; set; }

}
