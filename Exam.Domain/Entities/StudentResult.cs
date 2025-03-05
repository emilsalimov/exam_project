using System.ComponentModel.DataAnnotations;

namespace Exam.Domain.Entities;
public class StudentResult: BaseEntity
{
    public bool IsCorrectResult { get; set; }
    public int StudentExamId { get; set; }
    public int QuestionId { get; set; }
    public int AnswerId { get; set; }
    public Answer Answer { get; set; }
    public Question Question { get; set; }
    public StudentExam StudentExam { get; set; }
}
