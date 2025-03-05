namespace Exam.Domain.Entities;
public class Exam: BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public decimal Duration { get; set; }
    public List<Question> Questions { get; set; }
    public List<StudentExam> StudentExams { get; set; }


 //   public ICollection<StudentExam> StudentExams { get; set; }
}
