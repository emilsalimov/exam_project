namespace Exam.Domain.Entities;
public class Answer: BaseEntity
{
    public string AnswerText { get; set; }
    public bool IsCorrect { get; set; }
    public int QuestionId { get; set; }
    public StudentResult StudentResut { get; set; }
    public Question Question { get; set; }

}
