using System.ComponentModel.DataAnnotations;

namespace Exam.Domain.Entities;
public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}
