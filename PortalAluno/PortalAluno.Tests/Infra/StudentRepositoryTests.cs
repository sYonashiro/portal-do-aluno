using System;
using PortalAluno.Domain.Core.Interfaces;
using PortalAluno.Domain.Entities;
using PortalAluno.Domain.Interfaces;
using PortalAluno.Domain.ValueObjects;
using PortalAluno.Infra.CrossCutting.IoC;
using Xunit;
using Assert = Xunit.Assert;

namespace PortalAluno.Tests.Infra
{
    public class StudentRepositoryTests
    {
        private SimpleInjectorContainer _container;
        private IStudentRepository _studentRepository;
        private IUnitOfWork _uow;
        private Student _student;
        private Name _name;
        private Address _address;
        private Email _email;

        public StudentRepositoryTests()
        {
            _container = new SimpleInjectorContainer();
            _container.RegisterDependencies();
            _studentRepository = _container.GetInstance<IStudentRepository>();
            _uow = _container.GetInstance<IUnitOfWork>();

            _name = new Name("Vivi", "Pode subir");
            _address = new Address("Brasil", "SP", "Sorocaba", "Teste", "Rua A", 50, "");
            _email = new Email("teste@teste.com");
            _student = new Student(Guid.NewGuid(), _name, _address, _email, "(15)98011-1551");
        }

        [Fact]
        public void ShouldReturnTrueWhenStudentIsAdded()
        {
            _studentRepository.Add(_student);
            Assert.True(_uow.Commit());
        }

        [Fact]
        public void ShouldReturnTrueWhenStudentIsUpdated()
        {
            _name = new Name("Fulano", "De Tal");
            _address = new Address("Brasil", "SP", "Sorocaba", "Teste", "Rua A", 50, "");
            _email = new Email("teste@teste.com");
            _student = new Student(Guid.Parse("bd2dd14b-8634-499c-a478-554b626b79f6"), _name, _address, _email, "(15)98011-1551");

            _studentRepository.Update(_student);
            Assert.True(_uow.Commit());
        }
    }
}
