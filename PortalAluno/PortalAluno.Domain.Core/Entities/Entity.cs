using FluentValidation;
using FluentValidation.Results;
using System;

namespace PortalAluno.Domain.Core.Entities
{
    public abstract class Entity<T> : AbstractValidator<T> where T : class
    {
        private ValidationResult _validationResult;

        protected Entity()
        {
            _validationResult = new ValidationResult();
        }

        public Guid Id { get; protected set; }
        public ValidationResult ValidationResult => _validationResult;

        public bool IsValid => _validationResult.IsValid;

        public void SetValidationResult(ValidationResult validationResult) =>
            _validationResult = validationResult;
    }
}
