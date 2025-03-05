namespace Exam.Appilication.Dtos;
public class QuestionDto
{
    public int Id { get; set; }
    public int ExamId { get; set; }
    public string QuestionText { get; set; }
    public string QuestionType { get; set; }
    public decimal Points { get; set; }
}
