using Autofac;
using HealthCatalyst.PSA.Repository;
using HealthCatalyst.PSA.Repository.Abstract;
using HealthCatalyst.PSA.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.IoC
{
    /// <summary>
    /// This class registers Repository Interfaces to Repository Concrete Classes
    /// </summary>
    public class RepositoryRegister:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonRepository>().As<IPersonRepository>();
        }
    }
}
