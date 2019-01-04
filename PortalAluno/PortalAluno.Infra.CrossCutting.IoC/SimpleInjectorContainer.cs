using PortalAluno.Domain.Core.Interfaces;
using PortalAluno.Domain.Handlers;
using PortalAluno.Domain.Interfaces;
using PortalAluno.Infra.Data.Repositories;
using PortalAluno.Infra.Data.UoW;
using SimpleInjector;

namespace PortalAluno.Infra.CrossCutting.IoC
{
    public class SimpleInjectorContainer : Container
    {
        public void RegisterDependencies()
        {
            // Domain
            Register<IStudentHandler, StudentHandler>(Lifestyle.Scoped);

            // Infra - Data
            Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            Register<IStudentRepository, StudentRepository>(Lifestyle.Scoped);
        }
    }
}
