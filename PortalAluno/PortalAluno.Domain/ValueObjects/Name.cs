using FluentValidation;
using PortalAluno.Domain.Core.ValueObjects;

namespace PortalAluno.Domain.ValueObjects
{
    public class Name : ValueObject<Name>
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("O primeiro nome deve ter no mínimo 2 caracteres.");
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage("O sobrenome deve ter no mínimo 2 caracteres.");

            SetValidationResult(Validate(this));
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() =>
            $"{FirstName} {LastName}";
    }
}
