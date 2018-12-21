using System;

namespace PortalAluno.Domain.Commands.Student
{
    public class RemoveStudentCommand : StudentCommand
    {
        public RemoveStudentCommand(Guid id)
        {
            Id = id;
        }
    }
}
