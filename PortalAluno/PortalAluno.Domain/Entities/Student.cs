using FluentValidation;
using PortalAluno.Domain.Core.Entities;
using PortalAluno.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace PortalAluno.Domain.Entities
{
    public class Student : Entity<Student>
    {
        private IList<Class> _classes;

        public Student(Name name, Address address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
            _classes = new List<Class>();
            
            RuleFor(x => x.Phone).Matches("\\(\\d{2}?\\) \\d{3,5}-\\d{4}?").WithMessage("Telefone inválido. O número de telefone deve conter o DDD com 2 números entre parênteses, a primeira parte de 3 a 5 dígitos seguidos de um traço, e a segunda parte deve conter 4 dígitos.");
        }

        public Name Name { get; private set; }
        public Address Address { get; private set; }
        public string Phone { get; private set; }
        public Email Email { get; private set; }

        public IReadOnlyCollection<Class> Classes => _classes.ToList();

        public void AddClass(Class studentClass)
        {
            _classes.Add(studentClass);
        }
    }
}
