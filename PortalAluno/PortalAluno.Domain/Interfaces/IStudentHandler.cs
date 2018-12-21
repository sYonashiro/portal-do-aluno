using PortalAluno.Domain.Commands.Student;

namespace PortalAluno.Domain.Interfaces
{
    public interface IStudentHandler
    {
        void Handle(AddNewStudentCommand command);
        void Handle(UpdateStudentCommand command);
        void Handle(RemoveStudentCommand command);
    }
}
