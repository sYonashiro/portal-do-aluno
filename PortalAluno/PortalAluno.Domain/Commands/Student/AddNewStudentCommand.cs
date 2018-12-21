namespace PortalAluno.Domain.Commands.Student
{
    public class AddNewStudentCommand : StudentCommand
    {
        public AddNewStudentCommand(string firstName, 
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
