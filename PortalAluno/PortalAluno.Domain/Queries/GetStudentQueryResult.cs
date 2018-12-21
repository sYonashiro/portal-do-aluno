using PortalAluno.Domain.Core.Interfaces;
using System.Collections.Generic;

namespace PortalAluno.Domain.Queries
{
    public class GetStudentQueryResult : IQueryResult
    {
        // Name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Address
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Building { get; set; } // Complemento

        public string Phone { get; set; }

        // Email
        public string EmailAddress { get; set; }

        public IEnumerable<GetClassQueryResult> Classes { get; set; }
    }
}
