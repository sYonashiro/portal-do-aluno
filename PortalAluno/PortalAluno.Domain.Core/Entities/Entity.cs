using FluentValidation;
using FluentValidation.Results;
using System;

namespace PortalAluno.Domain.Core.Entities
{
    public abstract class Entity<T> : AbstractValidator<T> where T : class
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            ValidationResult = new ValidationResult();
        }

        public Guid Id { get; private set; }
        public ValidationResult ValidationResult { get; protected set; }

        public bool IsValid => ValidationResult.IsValid;
    }
}
