using FluentValidation;
using PortalAluno.Domain.Core.ValueObjects;

namespace PortalAluno.Domain.ValueObjects
{
    public class Address : ValueObject<Address>
    {
        public Address(string country, string state, string city, string neighborhood, string street, int streetNumber, string building)
        {
            Country = country;
            State = state;
            City = city;
            Neighborhood = neighborhood;
            Street = street;
            StreetNumber = streetNumber;
            Building = building;

            RuleFor(x => x.Country).NotEmpty().WithMessage("É necessário preencher o campo país.");
            RuleFor(x => x.State).MinimumLength(2).WithMessage("O campo estado precisa ter no mínimo 2 caracteres.");
            RuleFor(x => x.City).NotEmpty().WithMessage("É necessário preencher o campo cidade.");
            RuleFor(x => x.Neighborhood).NotEmpty().WithMessage("É necessário preencher o campo bairro.");
            RuleFor(x => x.Street).NotEmpty().WithMessage("É necessário preencher o campo rua.");

            SetValidationResult(Validate(this));
        }

        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Building { get; set; } // Complemento
    }
}
