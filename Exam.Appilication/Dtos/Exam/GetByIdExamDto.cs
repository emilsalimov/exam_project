namespace Exam.Appilication.Dtos.Exam;

public record GetByIdExamDto(int id, string Name, string Description, DateTime Date, decimal Duration);
