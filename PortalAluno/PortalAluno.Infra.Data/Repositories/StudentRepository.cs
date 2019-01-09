using PortalAluno.Domain.Entities;
using PortalAluno.Domain.Interfaces;
using PortalAluno.Domain.Queries;
using PortalAluno.Infra.Data.DataContexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace PortalAluno.Infra.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);       
        }
        
        public IEnumerable<GetStudentQueryResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public GetStudentQueryResult GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }
    }
}
