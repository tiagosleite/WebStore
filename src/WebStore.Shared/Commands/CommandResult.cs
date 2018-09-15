using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using WebStore.Shared.Entities;

namespace WebStore.Shared.Commands
{
    public class CommandResult
    {
        public CommandResult() { }
        public CommandResult(ValidationResult validationResult)
        {
            AddValidationResult(validationResult);    
        }

        public object Value { get; set; }
        public IList<string> Messages { get; set; }
        public string Message { get; set; }
        public bool IsValid { get { return Messages.Count == 0; } }

        public void AddValidationResult(ValidationResult validationResult)
        {
            Messages = validationResult?.Errors.Select(x => x.ErrorMessage).ToList() ?? new List<string>();
        }
    }
}