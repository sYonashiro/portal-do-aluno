using PortalAluno.Domain.Entities;
using System.Data.Entity;

namespace PortalAluno.Infra.Data.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext() : base(@"Server=DEVSQL;Database=PortalAluno;User=sa;Password=saadmin")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}
