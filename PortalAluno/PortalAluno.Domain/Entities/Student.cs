using PortalAluno.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PortalAluno.Domain.Entities
{
    public class Student
    {
        private IList<Class> _classes;

        public Student(Name name, string address, string phone)
        {
            Id = new Guid();
            Name = name;
            Address = address;
            Phone = phone;
            _classes = new List<Class>();
        }

        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }

        public IReadOnlyCollection<Class> Classes => _classes.ToList();

        public void AddClass(Class studentClass)
        {
            _classes.Add(studentClass);
        }
    }
}
