using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class HomeworkValidator : AbstractValidator<Homework>
    {
        public HomeworkValidator()
        {
            RuleFor(h => h.Name).MinimumLength(5).MaximumLength(200);
            RuleFor(h=> h.Description).MinimumLength(10).MaximumLength(500);
            RuleFor(h => h.Date).GreaterThan(DateTime.Now);
        }
    }
}
