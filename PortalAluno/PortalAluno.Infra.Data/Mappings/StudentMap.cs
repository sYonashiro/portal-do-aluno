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
            Property(x => x.Name.FirstName);
            Property(x => x.Name.LastName);
            Property(x => x.Address.Country);
            Property(x => x.Address.State);
            Property(x => x.Address.City);
            Property(x => x.Address.Neighborhood);
            Property(x => x.Address.Building);
            Property(x => x.Address.Street);
            Property(x => x.Address.StreetNumber);
            Property(x => x.Phone);
            Property(x => x.Email.Address).HasColumnName("Email");
            HasMany(x => x.Classes);

            Ignore(x => x.CascadeMode);
        }
    }
}
