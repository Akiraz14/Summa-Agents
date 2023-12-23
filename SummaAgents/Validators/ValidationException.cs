namespace SummaAgents.Validators
{
    public class ValidationException : Exception
    {
        public IEnumerable<string> ValidationErrors { get; }

        public ValidationException(string message, IEnumerable<string> validationErrors)
            : base(message)
        {
            ValidationErrors = validationErrors;
        }
    }
}
