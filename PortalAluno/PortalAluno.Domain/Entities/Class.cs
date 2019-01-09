using FluentValidation;
using PortalAluno.Domain.Core.Entities;
using System;

namespace PortalAluno.Domain.Entities
{
    public class Class : Entity<Class>
    {
        // Construtor vazio para o Entity Framework
        public Class() { }

        public Class(Guid id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;

            RuleFor(x => x.Name).NotEmpty().WithMessage("É necessário preencher o nome da matéria.");
            RuleFor(x => x.Grade).ExclusiveBetween(0, 10).WithMessage("A nota deve estar entre 0 e 10.");

            SetValidationResult(Validate(this));
        }

        public string Name { get; private set; }
        public double Grade { get; private set; }
    }
}
