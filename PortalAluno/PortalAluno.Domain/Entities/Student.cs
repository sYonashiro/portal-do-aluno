using FluentValidation;
using FluentValidation.Results;
using PortalAluno.Domain.Core.Entities;
using PortalAluno.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace PortalAluno.Domain.Entities
{
    public class Student : Entity<Student>
    {
        private readonly IList<Class> _classes;

        // Construtor vazio para o Entity Framework
        protected Student() { }

        public Student(Name name, Address address, Email email, string phone)
        {
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
            _classes = new List<Class>();
            
            RuleFor(x => x.Phone).Matches("\\(\\d{2}?\\) \\d{3,5}-\\d{4}?").WithMessage("Telefone inválido. O número de telefone deve conter o DDD com 2 números entre parênteses, a primeira parte de 3 a 5 dígitos seguidos de um traço, e a segunda parte deve conter 4 dígitos.");

            RuleFor(x => x.Name)
                .Must(Name => Name.IsValid)
                .WithMessage(x => !x.Name.IsValid ? Name.ValidationResult?.Errors.First().ErrorMessage : string.Empty);

            RuleFor(x => x.Address)
                .Must(Address => Address.IsValid)
                .WithMessage(x => !x.Address.IsValid ? Address.ValidationResult?.Errors.First().ErrorMessage : string.Empty);

            RuleFor(x => x.Email)
                .Must(Email => Email.IsValid)
                .WithMessage(x => !x.Email.IsValid ? Email.ValidationResult?.Errors.First().ErrorMessage : string.Empty);

            ValidationResult = Validate(this);
        }

        public Name Name { get; private set; }
        public Address Address { get; private set; }
        public string Phone { get; private set; }
        public Email Email { get; private set; }

        public ICollection<Class> Classes => _classes.ToList();

        public void AddClass(Class studentClass)
        {
            if (studentClass.IsValid)
                _classes.Add(studentClass);
            else
                ValidationResult.Errors.Add(studentClass.ValidationResult.Errors.First());
        }
    }
}
