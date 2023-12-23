using FluentValidation;

namespace SummaAgents.Validators
{
    public class AgentValidator : AbstractValidator<int>
    {
        public AgentValidator()
        {
            RuleFor(x => x).Empty();
            RuleFor(x => x).GreaterThan(0);
            RuleFor(x => x).LessThanOrEqualTo(100);
        }
    }
}
