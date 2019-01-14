using PortalAluno.Domain.Commands.Student;
using PortalAluno.Domain.Core.Commands;
using PortalAluno.Domain.Core.Interfaces;
using PortalAluno.Domain.Entities;
using PortalAluno.Domain.Interfaces;
using PortalAluno.Domain.ValueObjects;
using System.Linq;

namespace PortalAluno.Domain.Handlers
{
    public class StudentHandler : IStudentHandler
    {
        private IStudentRepository _studentRepository;
        private IUnitOfWork _uow;

        public StudentHandler(IStudentRepository studentRepository, IUnitOfWork uow)
        {
            _studentRepository = studentRepository;
            _uow = uow;
        }

        public CommandResult Handle(AddNewStudentCommand command)
        {
            var name = new Name(command.FirstName, command.LastName);
            var address = new Address(command.Country, command.State, command.City, command.Neighborhood, command.Street, command.StreetNumber, command.Building);
            var email = new Email(command.EmailAddress);

            var student = new Student(command.Id, name, address, email, command.Phone);

            if (!student.IsValid)
                return new CommandResult(false, student.ValidationResult.Errors.First().ErrorMessage);

            _studentRepository.Add(student);

            if (_uow.Commit())
                return new CommandResult(true, "Estudante adicionado com sucesso!");

            return new CommandResult(false, "Erro ao tentar salvar o aluno!");
        }

        public CommandResult Handle(UpdateStudentCommand command)
        {
            var name = new Name(command.FirstName, command.LastName);
            var address = new Address(command.Country, command.State, command.City, command.Neighborhood, command.Street, command.StreetNumber, command.Building);
            var email = new Email(command.EmailAddress);

            var student = new Student(command.Id, name, address, email, command.Phone);

            if (!student.IsValid)
                return new CommandResult(false, student.ValidationResult.Errors.First().ErrorMessage);

            _studentRepository.Update(student);

            if (_uow.Commit())
                return new CommandResult(true, "Estudante atualizado com sucesso!");

            return new CommandResult(false, "Erro ao tentar atualizar o aluno!");
        }

        public CommandResult Handle(RemoveStudentCommand command)
        {
            var result = _studentRepository.GetById(command.Id);

            var name = new Name(result.FirstName, result.LastName);
            var address = new Address(result.Country, result.State, result.City, result.Neighborhood, result.Street, result.StreetNumber, result.Building);
            var email = new Email(result.Email);

            var student = new Student(command.Id, name, address, email, result.Phone);
            _studentRepository.Remove(student);

            if (_uow.Commit())
                return new CommandResult(true, "Estudante removido com sucesso!");

            return new CommandResult(false, "Erro ao tentar remover o aluno!");
        }
    }
}
