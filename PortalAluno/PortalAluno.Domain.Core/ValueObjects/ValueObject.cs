using FluentValidation;
using FluentValidation.Results;

namespace PortalAluno.Domain.Core.ValueObjects
{
    public abstract class ValueObject<T> : AbstractValidator<T> where T : class
    {
        private ValidationResult _validationResult;

        protected ValueObject()
        {
            _validationResult = new ValidationResult();
        }

        public ValidationResult ValidationResult => _validationResult;
        public bool IsValid => ValidationResult.IsValid;

        public void SetValidationResult(ValidationResult validationResult) =>
            _validationResult = validationResult;
    }
}
