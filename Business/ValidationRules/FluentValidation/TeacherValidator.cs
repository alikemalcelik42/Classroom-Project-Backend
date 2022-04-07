using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TeacherValidator : AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(t => t.FirstName).MinimumLength(2).MaximumLength(200);
            RuleFor(t => t.LastName).MinimumLength(2).MaximumLength(200);
            RuleFor(t => t.PhoneNumber).Length(11);
            RuleFor(t => t.NationalNumber).Length(11);
        }
    }
}
