using PortalAluno.Domain.Entities;
using PortalAluno.Infra.Data.Mappings;
using System.Data.Entity;
using PortalAluno.Domain.ValueObjects;

namespace PortalAluno.Infra.Data.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext() : base(@"Server=DEVSQL;Database=PortalAluno;User Id=sa;Password=saadmin")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Ignorar propriedades que não devem ser mapeadas

            modelBuilder.Types<Student>().Configure(c => c.Ignore(p => p.CascadeMode));
            modelBuilder.Types<Name>().Configure(c => c.Ignore(p => p.CascadeMode));
            modelBuilder.Types<Email>().Configure(c => c.Ignore(p => p.CascadeMode));
            modelBuilder.Types<Address>().Configure(c => c.Ignore(p => p.CascadeMode));
            modelBuilder.Types<Class>().Configure(c => c.Ignore(p => p.CascadeMode));

            #endregion

            modelBuilder.Configurations.Add(new StudentMap());
        }
    }
}
