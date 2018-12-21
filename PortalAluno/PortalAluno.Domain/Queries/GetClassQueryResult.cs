using PortalAluno.Domain.Core.Interfaces;

namespace PortalAluno.Domain.Queries
{
    public class GetClassQueryResult : IQueryResult
    {
        public string Name { get; set; }
        public double Grade { get; set; }
    }
}
