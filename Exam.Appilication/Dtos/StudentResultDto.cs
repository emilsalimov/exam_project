namespace Exam.Appilication.Dtos;
public class StudentResultDto
{
    public int StudentAnswerId { get; set; }
    public int StudentExamId { get; set; }
    public int QuestionId { get; set; }
    public int AnswerId { get; set; }
    public bool IsCorrectResult { get; set; }
}
