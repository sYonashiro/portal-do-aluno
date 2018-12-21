using PortalAluno.Domain.Commands.Class;
using PortalAluno.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace PortalAluno.Domain.Commands.Student
{
    public abstract class StudentCommand : ICommand
    {
        public Guid Id { get; protected set; }

        // Name
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        // Address
        public string Country { get; protected set; }
        public string State { get; protected set; }
        public string City { get; protected set; }
        public string Neighborhood { get; protected set; }
        public string Street { get; protected set; }
        public int StreetNumber { get; protected set; }
        public string Building { get; protected set; } // Complemento

        public string Phone { get; protected set; }

        // Email
        public string EmailAddress { get; protected set; }

        IList<ClassCommand> Classes { get; set; }
    }
}
