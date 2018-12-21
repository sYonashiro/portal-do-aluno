using System;

namespace PortalAluno.Domain.Commands.Student
{
    public class UpdateStudentCommand : StudentCommand
    {
        public UpdateStudentCommand(Guid id,
                                    string firstName,
                                    string lastName,
                                    string country,
                                    string state,
                                    string city,
                                    string neighborhood,
                                    string street,
                                    int streetNumber,
                                    string building,
                                    string phone,
                                    string emailAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            State = state;
            City = city;
            Neighborhood = neighborhood;
            Street = street;
            StreetNumber = streetNumber;
            Building = building;
            Phone = phone;
            EmailAddress = emailAddress;
        }
    }
}
