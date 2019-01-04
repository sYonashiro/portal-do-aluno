using PortalAluno.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalAluno.Infra.Data.Mappings
{
    public class ClassMap : EntityTypeConfiguration<Class>
    {
        public ClassMap()
        {
            ToTable("Class");
            HasKey(x => x.Id);
            Property(x => x.Grade);
            Property(x => x.Name);

            Ignore(x => x.CascadeMode);
        }
    }
}
