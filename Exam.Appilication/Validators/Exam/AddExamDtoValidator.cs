using Exam.Appilication.Dtos.Exam;
using FluentValidation;

namespace Exam.Appilication.Validators.Exam;
public class AddExamDtoValidator : AbstractValidator<AddExamDTO>
{
    public AddExamDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull().WithMessage("Name is required");

        RuleFor(x => x.Duration)
            .Must(duration => duration >= 0);


        RuleFor(x => x.Date)
            .Must(date => date >= DateTime.UtcNow);
    }
}
