namespace Exam.Appilication.Dtos.User;

public record UpdateUserDto(int id,string Name, string FullName, string Password, string Email, string Role);
