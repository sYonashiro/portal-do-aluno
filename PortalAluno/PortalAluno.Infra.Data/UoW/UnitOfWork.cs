using PortalAluno.Domain.Core.Interfaces;
using PortalAluno.Infra.Data.DataContexts;

namespace PortalAluno.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public bool Commit() => _context.SaveChanges() > 0;        
    }
}
