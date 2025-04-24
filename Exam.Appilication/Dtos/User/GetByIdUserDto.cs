namespace Exam.Appilication.Dtos.User;

public record GetByIdUserDto(int id, string Name, string FullName, string Password, string Email, string Role);
