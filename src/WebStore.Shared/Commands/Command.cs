using FluentValidation.Results;

namespace WebStore.Shared.Commands
{
    public abstract class Command
    {
        public ValidationResult ValidationResult { get; set; }
        public abstract CommandResult Validate();
    }
}