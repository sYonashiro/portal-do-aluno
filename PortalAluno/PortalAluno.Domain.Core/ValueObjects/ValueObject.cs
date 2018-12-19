using FluentValidation;
using FluentValidation.Results;

namespace PortalAluno.Domain.Core.ValueObjects
{
    public abstract class ValueObject<T> : AbstractValidator<T> where T : class
    {
        protected ValueObject()
        {
            ValidationResult = new ValidationResult();
        }

        public ValidationResult ValidationResult { get; protected set; }
        public bool IsValid => ValidationResult.IsValid;
    }
}
