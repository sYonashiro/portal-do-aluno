using PortalAluno.Domain.Commands.Student;
using PortalAluno.Domain.Interfaces;

namespace PortalAluno.Domain.Handlers
{
    public class StudentHandler : IStudentHandler
    {
        private IStudentRepository _studentRepository;

        public StudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Handle(AddNewStudentCommand command)
        {
            throw new System.NotImplementedException();
        }

        public void Handle(UpdateStudentCommand command)
        {
            throw new System.NotImplementedException();
        }

        public void Handle(RemoveStudentCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
