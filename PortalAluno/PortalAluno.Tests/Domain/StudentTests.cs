using System;
using PortalAluno.Domain.Entities;
using Xunit;
using PortalAluno.Domain.ValueObjects;

namespace PortalAluno.Tests.Domain
{
    public class StudentTests
    {
        private Name _validName;
        private Address _validAddress;
        private Email _validEmail;
        private string _validPhone;

        public StudentTests()
        {
            _validName = new Name("Fulano", "De Tal");
            _validAddress = new Address("Brasil", "SP", "Sorocaba", "Teste", "Rua A", 50, "");
            _validEmail = new Email("teste@teste.com");
            _validPhone = "(15)98011-1551";
        }

        [Fact]
        public void ShouldBeValidIfStudentIsValid()
        {
            var student = new Student(Guid.NewGuid(), _validName, _validAddress, _validEmail, _validPhone);
            Assert.True(student.IsValid);
        }

        [Fact]
        public void ShouldBeInvalidIfStudentNameIsInvalid()
        {
            var name = new Name("", "De Tal");
            var studentWithInvalidName = new Student(Guid.NewGuid(), name, _validAddress, _validEmail, _validPhone);

            Assert.False(studentWithInvalidName.IsValid);
        }

        [Fact]
        public void ShouldBeInvalidIfStudentAddressIsInvalid()
        {
            var address = new Address("Brasil", "", "Sorocaba", "Teste", "Rua A", 50, "");
            var studentWithInvalidAddress = new Student(Guid.NewGuid(), _validName, address, _validEmail, _validPhone);

            Assert.False(studentWithInvalidAddress.IsValid);
        }

        [Fact]
        public void ShouldBeInvalidIfStudentEmailIsInvalid()
        {
            var email = new Email("teste@t");
            var studentWithInvalidEmail = new Student(Guid.NewGuid(), _validName, _validAddress, email, _validPhone);

            Assert.False(studentWithInvalidEmail.IsValid);
        }

        [Fact]
        public void ShouldBeInvalidIfStudentPhoneIsInvalid()
        {
            var phone = "(15)98819-225";
            var studentWithInvalidPhone = new Student(Guid.NewGuid(), _validName, _validAddress, _validEmail, phone);

            Assert.False(studentWithInvalidPhone.IsValid);
        }
    }
}
