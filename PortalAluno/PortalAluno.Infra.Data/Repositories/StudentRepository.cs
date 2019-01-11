using PortalAluno.Domain.Entities;
using PortalAluno.Domain.Interfaces;
using PortalAluno.Domain.Queries;
using PortalAluno.Infra.Data.DataContexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

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
            using (SqlConnection connection = new SqlConnection(@"Server=DEVSQL;Database=PortalAluno;User Id=sa;Password=saadmin"))
            {
                return connection
                    .Query<GetStudentQueryResult>(@" SELECT [FirstName]
                                                           ,[LastName]
                                                           ,[Country]
                                                           ,[State]
                                                           ,[City]
                                                           ,[Neighborhood]
                                                           ,[Street]
                                                           ,[StreetNumber]
                                                           ,[Building]
                                                           ,[Phone]
                                                           ,[Email]
                                                     FROM [Student] ");
            }
        }

        public GetStudentQueryResult GetById(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=DEVSQL;Database=PortalAluno;User Id=sa;Password=saadmin"))
            {
                return connection
                    .Query<GetStudentQueryResult>($@" SELECT [FirstName]
                                                           ,[LastName]
                                                           ,[Country]
                                                           ,[State]
                                                           ,[City]
                                                           ,[Neighborhood]
                                                           ,[Street]
                                                           ,[StreetNumber]
                                                           ,[Building]
                                                           ,[Phone]
                                                           ,[Email]
                                                      FROM [Student] 
                                                      WHERE [Id] = '{id}' ")
                    .FirstOrDefault();
            }
        }

        public void Remove(Student student)
        {
            _context.Entry(student).State = EntityState.Deleted;
        }

        public void Update(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }
    }
}
