using PortalAluno.Domain.Entities;
using PortalAluno.Domain.Queries;
using System;
using System.Collections.Generic;

namespace PortalAluno.Domain.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        void Update(Student student);
        void Remove(Guid id);
        IEnumerable<GetStudentQueryResult> GetAll();
        GetStudentQueryResult GetById(Guid id);
    }
}
