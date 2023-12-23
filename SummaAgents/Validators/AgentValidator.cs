using FluentValidation;

namespace SummaAgents.Validators
{
    public class AgentValidator : AbstractValidator<int>
    {
        public AgentValidator()
        {
            RuleFor(x => x).NotEmpty();
            RuleFor(x => x).GreaterThan(0);
            RuleFor(x => x).LessThan(100);
        }
    }
}
