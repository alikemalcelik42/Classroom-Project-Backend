using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.FirstName).MinimumLength(2).MaximumLength(200);
            RuleFor(s => s.LastName).MinimumLength(2).MaximumLength(200);
            RuleFor(s => s.PhoneNumber).Length(11);
            RuleFor(s => s.NationalNumber).Length(11);
        }
    }
}
