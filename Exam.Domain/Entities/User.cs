using System.ComponentModel.DataAnnotations;

namespace Exam.Domain.Entities;

public class User: BaseEntity
{
    public string Name { get; set; }
    public string FullName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public DateTime CreateDate { get; set; }
    public List<StudentExam> StudentExams { get; set; }
    
}
