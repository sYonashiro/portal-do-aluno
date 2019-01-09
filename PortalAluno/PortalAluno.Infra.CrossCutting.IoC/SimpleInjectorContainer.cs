using PortalAluno.Domain.Core.Interfaces;
using PortalAluno.Domain.Handlers;
using PortalAluno.Domain.Interfaces;
using PortalAluno.Infra.Data.DataContexts;
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
            Register<IStudentHandler, StudentHandler>(Lifestyle.Singleton);

            // Infra - Data
            Register<DataContext>(Lifestyle.Singleton);
            Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);
            Register<IStudentRepository, StudentRepository>(Lifestyle.Singleton);
        }
    }
}
