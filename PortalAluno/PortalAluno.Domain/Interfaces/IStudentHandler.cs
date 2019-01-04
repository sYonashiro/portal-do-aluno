using PortalAluno.Domain.Commands.Student;
using PortalAluno.Domain.Core.Commands;

namespace PortalAluno.Domain.Interfaces
{
    public interface IStudentHandler
    {
        CommandResult Handle(AddNewStudentCommand command);
        void Handle(UpdateStudentCommand command);
        void Handle(RemoveStudentCommand command);
    }
}
