using PortalAluno.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalAluno.Infra.Data.Mappings
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            ToTable("Student");
            HasKey(x => x.Id);
            Property(x => x.Name.FirstName).HasColumnName("FirstName");
            Property(x => x.Name.LastName).HasColumnName("LastName");
            Property(x => x.Address.Country).HasColumnName("Country");
            Property(x => x.Address.State).HasColumnName("State");
            Property(x => x.Address.City).HasColumnName("City");
            Property(x => x.Address.Neighborhood).HasColumnName("Neighborhood"); 
            Property(x => x.Address.Building).HasColumnName("Building");
            Property(x => x.Address.Street).HasColumnName("Street"); 
            Property(x => x.Address.StreetNumber).HasColumnName("StreetNumber"); 
            Property(x => x.Phone);
            Property(x => x.Email.Address).HasColumnName("Email");
            HasMany(x => x.Classes);

            Ignore(x => x.CascadeMode);
        }
    }
}
