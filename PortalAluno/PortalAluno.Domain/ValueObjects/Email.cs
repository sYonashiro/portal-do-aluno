using FluentValidation;
using PortalAluno.Domain.Core.ValueObjects;

namespace PortalAluno.Domain.ValueObjects
{
    public class Email : ValueObject<Email>
    {
        public Email(string address)
        {
            Address = address;

            RuleFor(x => x.Address).EmailAddress().WithMessage("Email inválido.");

            SetValidationResult(Validate(this));
        }

        public string Address { get; set; }
    }
}
