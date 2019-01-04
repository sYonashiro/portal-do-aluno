namespace PortalAluno.Domain.Core.Interfaces
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
