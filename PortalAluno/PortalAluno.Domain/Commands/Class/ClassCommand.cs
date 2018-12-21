using PortalAluno.Domain.Core.Interfaces;

namespace PortalAluno.Domain.Commands.Class
{
    public class ClassCommand : ICommand
    {
        public string Name { get; set; }
        public double Grade { get; set; }
    }
}
