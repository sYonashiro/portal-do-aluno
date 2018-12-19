using FluentValidation;
using PortalAluno.Domain.Core.Entities;

namespace PortalAluno.Domain.Entities
{
    public class Class : Entity<Class>
    {
        public Class(string name, double grade)
        {
            Name = name;
            Grade = grade;

            RuleFor(x => x.Name).NotEmpty().WithMessage("É necessário preencher o nome da matéria.");
            RuleFor(x => x.Grade).ExclusiveBetween(0, 10).WithMessage("A nota deve estar entre 0 e 10.");

            ValidationResult = Validate(this);
        }

        public string Name { get; private set; }
        public double Grade { get; private set; }
    }
}
