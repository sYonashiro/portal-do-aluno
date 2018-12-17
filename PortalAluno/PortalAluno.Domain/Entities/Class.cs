using PortalAluno.Domain.Core.Entities;
using System;

namespace PortalAluno.Domain.Entities
{
    public class Class : Entity<Class>
    {
        public Class(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Name { get; private set; }
        public double Grade { get; private set; }
    }
}
