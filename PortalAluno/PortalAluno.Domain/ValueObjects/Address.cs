namespace PortalAluno.Domain.ValueObjects
{
    public class Address
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
